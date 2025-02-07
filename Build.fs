open Fake
open Fake.Core
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators
open System
open System.IO

open BuildHelpers
open BuildTools

initializeContext()

let publishPath = Path.getFullName "publish"
let srcPath = Path.getFullName "src"
let clientSrcPath = srcPath </> "Docs"
let librarySrcPath = srcPath </> "Feliz.Tailwind"
let appPublishPath = publishPath </> "app"

// Targets
let clean proj = [ proj </> "bin"; proj </> "obj" ] |> Shell.cleanDirs

Target.create "InstallClient" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" clientSrcPath
    printfn "Npm version:"
    Tools.npm "--version" clientSrcPath
    Tools.npm "install" clientSrcPath
)

let createNuget proj =
    clean proj
    Tools.npm "install" proj
    Tools.dotnet "restore --no-cache" proj
    Tools.dotnet "pack -c Release" proj

let getBuildParam = Environment.environVar
let isNullOrWhiteSpace = String.IsNullOrWhiteSpace

let publishNuget proj =
    createNuget proj
    let nugetKey =
        match getBuildParam "nugetkey" with
        | s when not (isNullOrWhiteSpace s) -> s
        | _ -> UserInput.getUserPassword "NuGet Key: "
    let nupkg =
        Directory.GetFiles(proj </> "bin" </> "Release")
        |> Seq.head
        |> Path.GetFullPath
    Tools.dotnet (sprintf "nuget push %s -s nuget.org -k %s" nupkg nugetKey) proj

Target.create "Pack" (fun _ ->
    createNuget librarySrcPath
)

Target.create "Publish" (fun _ ->
    publishNuget librarySrcPath
)

Target.create "PublishDocs" (fun _ ->
    Tools.npm "run build" ""
)

Target.create "RunDocs" (fun _ ->
    Tools.npm "run startdocs" "")

Target.create "Run" (fun _ ->
    Tools.npm "run start" ""
)

let dependencies = [
    "InstallClient" ==> "PublishDocs"
    "InstallClient" ==> "Pack"
    "InstallClient" ==> "Publish"
    "InstallClient" ==> "Run"
]

[<EntryPoint>]
let main args = runOrDefault "Run" args