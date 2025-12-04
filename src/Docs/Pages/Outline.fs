module Docs.Pages.Outline

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let outlineStyles = [
    outline.outlineNone
    outline.outline
    outline.outlineDashed
    outline.outlineDotted
    outline.outlineDouble
]

let str prop =
    if prop = outline.outlineNone then "outline.outlineNone"
    elif prop = outline.outline then "outline.outline"
    elif prop = outline.outlineDashed then "outline.outlineDashed"
    elif prop = outline.outlineDotted then "outline.outlineDotted"
    elif prop = outline.outlineDouble then "outline.outlineDouble"
    else "unknown"

let renderOutline outlineProp =
    let example =
        Tailwind.divCombine [
            outlineProp
            prop.className "p-4 bg-white outline-blue-500 outline-2"
            prop.text (str outlineProp)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str outlineProp}
    prop.className "p-4 bg-white outline-blue-500 outline-2"
    prop.text "{str outlineProp}"
]"""

    let title =
        Html.text
            "Use outline utilities to control the outline style of an element."
    codedView title code example

[<ReactComponent>]
let OutlineView () =
    React.fragment [
        for outlineProp in outlineStyles do
            renderOutline outlineProp
    ]
