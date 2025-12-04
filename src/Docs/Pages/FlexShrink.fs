module Docs.Pages.FlexShrink

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let flexShrinkStyles = [
    flexShrink.flexShrink
    flexShrink.flexShrink0
]

let str prop =
    if prop = flexShrink.flexShrink then "flexShrink.flexShrink"
    elif prop = flexShrink.flexShrink0 then "flexShrink.flexShrink0"
    else "unknown"

let renderFlexShrink shrinkProp =
    let example =
        Html.div [
            prop.className "flex w-64"
            prop.children [
                Tailwind.divCombine [
                    shrinkProp
                    prop.className "bg-blue-400 p-2 w-32"
                    prop.text (str shrinkProp)
                ]
                Html.div [
                    prop.className "flex-1 bg-gray-300 p-2"
                    prop.text "Other content"
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "flex w-64"
    prop.children [
        Tailwind.divCombine [
            {str shrinkProp}
            prop.className "bg-blue-400 p-2 w-32"
            prop.text "{str shrinkProp}"
        ]
        Html.div [
            prop.className "flex-1 bg-gray-300 p-2"
            prop.text "Other content"
        ]
    ]
]"""

    let title =
        Html.text
            "Use flexShrink to control how flex items shrink."
    codedView title code example

[<ReactComponent>]
let FlexShrinkView () =
    React.fragment [
        for shrinkProp in flexShrinkStyles do
            renderFlexShrink shrinkProp
    ]
