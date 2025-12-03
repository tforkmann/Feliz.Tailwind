module Docs.Pages.Opacity

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let opacityStyles = [
    opacity.opacity0
    opacity.opacity10
    opacity.opacity25
    opacity.opacity50
    opacity.opacity75
    opacity.opacity90
    opacity.opacity100
]

let str prop =
    if prop = opacity.opacity0 then "opacity.opacity0"
    elif prop = opacity.opacity10 then "opacity.opacity10"
    elif prop = opacity.opacity25 then "opacity.opacity25"
    elif prop = opacity.opacity50 then "opacity.opacity50"
    elif prop = opacity.opacity75 then "opacity.opacity75"
    elif prop = opacity.opacity90 then "opacity.opacity90"
    elif prop = opacity.opacity100 then "opacity.opacity100"
    else "unknown"

let renderOpacity opacityProp =
    let example =
        Tailwind.divCombine [
            opacityProp
            prop.className "bg-blue-500 p-4 text-white"
            prop.text (str opacityProp)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str opacityProp}
    prop.className "bg-blue-500 p-4 text-white"
    prop.text "{str opacityProp}"
]"""

    let title =
        Html.text
            "Use opacity utilities to control the opacity of an element."
    codedView title code example

[<ReactComponent>]
let OpacityView () =
    React.fragment [
        for opacityProp in opacityStyles do
            renderOpacity opacityProp
    ]
