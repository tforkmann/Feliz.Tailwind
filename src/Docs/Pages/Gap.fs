module Docs.Pages.Gap

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let gapStyles = [
    gap.``gap-0``
    gap.``gap-1``
    gap.``gap-2``
    gap.``gap-4``
    gap.``gap-6``
]

let str prop =
    if prop = gap.``gap-0`` then "gap.``gap-0``"
    elif prop = gap.``gap-1`` then "gap.``gap-1``"
    elif prop = gap.``gap-2`` then "gap.``gap-2``"
    elif prop = gap.``gap-4`` then "gap.``gap-4``"
    elif prop = gap.``gap-6`` then "gap.``gap-6``"
    else "unknown"

let renderGap gapProp =
    let example =
        Tailwind.divCombine [
            display.flex
            gapProp
            prop.children [
                Html.div [ prop.className "bg-blue-400 p-2 text-white"; prop.text "1" ]
                Html.div [ prop.className "bg-blue-500 p-2 text-white"; prop.text "2" ]
                Html.div [ prop.className "bg-blue-600 p-2 text-white"; prop.text "3" ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    display.flex
    {str gapProp}
    prop.children [
        Html.div [ prop.className "bg-blue-400 p-2 text-white"; prop.text "1" ]
        Html.div [ prop.className "bg-blue-500 p-2 text-white"; prop.text "2" ]
        Html.div [ prop.className "bg-blue-600 p-2 text-white"; prop.text "3" ]
    ]
]"""

    let title =
        Html.text
            "Use gap utilities to control gutters between grid and flexbox items."
    codedView title code example

[<ReactComponent>]
let GapView () =
    React.fragment [
        for gapProp in gapStyles do
            renderGap gapProp
    ]
