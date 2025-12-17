#!/usr/bin/env dotnet fsi

// Script to generate Strings.fs from Modifiers.fs
// Converts: static member inline xxx = prop.className "yyy"
// To:       let xxx = "yyy"

open System
open System.IO
open System.Text.RegularExpressions

let inputFile = __SOURCE_DIRECTORY__ + "/src/Feliz.Tailwind/Modifiers.fs"
let outputFile = __SOURCE_DIRECTORY__ + "/src/Feliz.Tailwind/Strings.fs"

let content = File.ReadAllText(inputFile)

// Parse type definitions
let typePattern = @"\[\<Erase\>\]\s*\ntype\s+(\w+)\s*="
let memberPattern = @"static\s+member\s+inline\s+(``[^``]+``|\w+'?)\s*=\s*prop\.className\s+""([^""]+)"""

let types = Regex.Matches(content, typePattern)
let members = Regex.Matches(content, memberPattern)

// Build output
let sb = System.Text.StringBuilder()

sb.AppendLine("/// Auto-generated from Modifiers.fs") |> ignore
sb.AppendLine("/// Pure string values for use with Fable.React, Giraffe, and SSR scenarios") |> ignore
sb.AppendLine("/// where Feliz's prop.className is not available.") |> ignore
sb.AppendLine("namespace Feliz.Tailwind") |> ignore
sb.AppendLine("") |> ignore
sb.AppendLine("[<AutoOpen>]") |> ignore
sb.AppendLine("module Strings =") |> ignore
sb.AppendLine("") |> ignore
sb.AppendLine("    /// Combines multiple Tailwind class names into a single string") |> ignore
sb.AppendLine("    let tw (classes: string list) =") |> ignore
sb.AppendLine("        classes") |> ignore
sb.AppendLine("        |> List.filter (System.String.IsNullOrWhiteSpace >> not)") |> ignore
sb.AppendLine("        |> String.concat \" \"") |> ignore
sb.AppendLine("") |> ignore

// Track current type for grouping
let mutable currentTypeStart = 0
let mutable currentTypeName = ""

// Find which type each member belongs to
let getTypeForPosition pos =
    let mutable result = ""
    for t in types do
        if t.Index < pos then
            result <- t.Groups.[1].Value
    result

// Group members by type
let membersByType =
    members
    |> Seq.cast<Match>
    |> Seq.groupBy (fun m -> getTypeForPosition m.Index)
    |> Seq.filter (fun (typeName, _) -> not (String.IsNullOrEmpty typeName))
    |> Seq.toList

for (typeName, typeMembers) in membersByType do
    sb.AppendLine($"    /// {typeName} utilities") |> ignore
    sb.AppendLine($"    module {typeName} =") |> ignore

    for m in typeMembers do
        let memberName = m.Groups.[1].Value
        let className = m.Groups.[2].Value
        // Handle F# escaped identifiers
        let safeMemberName =
            if memberName.StartsWith("``") then memberName
            elif memberName.EndsWith("'") then $"``{memberName}``"
            else memberName
        sb.AppendLine($"        let {safeMemberName} = \"{className}\"") |> ignore

    sb.AppendLine("") |> ignore

File.WriteAllText(outputFile, sb.ToString())
printfn "Generated %s" outputFile
printfn "Types found: %d" types.Count
printfn "Members found: %d" members.Count
