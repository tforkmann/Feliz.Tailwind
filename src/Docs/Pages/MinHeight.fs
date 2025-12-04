module Docs.Pages.MinHeight

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let minHeightStyles = [
    minHeight.minHAuto
    minHeight.minHFull
    minHeight.minHScreen
    minHeight.minHMin
    minHeight.minHMax
    minHeight.minHFit
]

let str prop =
    if prop = minHeight.minHAuto then "minHeight.minHAuto"
    elif prop = minHeight.minHFull then "minHeight.minHFull"
    elif prop = minHeight.minHScreen then "minHeight.minHScreen"
    elif prop = minHeight.minHMin then "minHeight.minHMin"
    elif prop = minHeight.minHMax then "minHeight.minHMax"
    elif prop = minHeight.minHFit then "minHeight.minHFit"
    else "unknown"

let renderMinHeight minH =
    let example =
        Html.div [
            prop.className "h-32 bg-gray-200"
            prop.children [
                Tailwind.divCombine [
                    minH
                    prop.className "bg-blue-400 p-2"
                    prop.text (str minH)
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "h-32 bg-gray-200"
    prop.children [
        Tailwind.divCombine [
            {str minH}
            prop.className "bg-blue-400 p-2"
            prop.text "{str minH}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use minHeight to set the minimum height of an element."
    codedView title code example

[<ReactComponent>]
let MinHeightView () =
    React.fragment [
        for minH in minHeightStyles do
            renderMinHeight minH
    ]
