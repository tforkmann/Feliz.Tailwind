module Docs.Pages.MaxHeight

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let maxHeightStyles = [
    maxHeight.h16
    maxHeight.h32
    maxHeight.h64
    maxHeight.hFull
    maxHeight.hScreen
]

let str prop =
    if prop = maxHeight.h16 then "maxHeight.h16"
    elif prop = maxHeight.h32 then "maxHeight.h32"
    elif prop = maxHeight.h64 then "maxHeight.h64"
    elif prop = maxHeight.hFull then "maxHeight.hFull"
    elif prop = maxHeight.hScreen then "maxHeight.hScreen"
    else "unknown"

let renderMaxHeight maxH =
    let example =
        Html.div [
            prop.className "h-48 bg-gray-200 overflow-auto"
            prop.children [
                Tailwind.divCombine [
                    maxH
                    prop.className "bg-blue-400 p-2"
                    prop.children [
                        Html.div [ prop.text (str maxH) ]
                        Html.div [ prop.className "h-96"; prop.text "Tall content..." ]
                    ]
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "h-48 bg-gray-200 overflow-auto"
    prop.children [
        Tailwind.divCombine [
            {str maxH}
            prop.className "bg-blue-400 p-2"
            prop.text "{str maxH}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use maxHeight to set the maximum height of an element."
    codedView title code example

[<ReactComponent>]
let MaxHeightView () =
    React.fragment [
        for maxH in maxHeightStyles do
            renderMaxHeight maxH
    ]
