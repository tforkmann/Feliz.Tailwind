module Docs.Pages.FlexGrow

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let flexGrowStyles = [
    flexGrow.flexGrow
    flexGrow.flexGrow0
]

let str prop =
    if prop = flexGrow.flexGrow then "flexGrow.flexGrow"
    elif prop = flexGrow.flexGrow0 then "flexGrow.flexGrow0"
    else "unknown"

let renderFlexGrow growProp =
    let example =
        Html.div [
            prop.className "flex gap-2"
            prop.children [
                Tailwind.divCombine [
                    growProp
                    prop.className "bg-blue-400 p-2"
                    prop.text (str growProp)
                ]
                Html.div [
                    prop.className "bg-gray-300 p-2"
                    prop.text "Fixed"
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "flex gap-2"
    prop.children [
        Tailwind.divCombine [
            {str growProp}
            prop.className "bg-blue-400 p-2"
            prop.text "{str growProp}"
        ]
        Html.div [
            prop.className "bg-gray-300 p-2"
            prop.text "Fixed"
        ]
    ]
]"""

    let title =
        Html.text
            "Use flexGrow to control how flex items grow."
    codedView title code example

[<ReactComponent>]
let FlexGrowView () =
    React.fragment [
        for growProp in flexGrowStyles do
            renderFlexGrow growProp
    ]
