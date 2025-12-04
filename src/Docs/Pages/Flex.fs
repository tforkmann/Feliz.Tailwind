module Docs.Pages.Flex

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let flexStyles = [
    flex.flex1
    flex.flexAuto
    flex.flexInitial
    flex.flexNone
]

let str prop =
    if prop = flex.flex1 then "flex.flex1"
    elif prop = flex.flexAuto then "flex.flexAuto"
    elif prop = flex.flexInitial then "flex.flexInitial"
    elif prop = flex.flexNone then "flex.flexNone"
    else "unknown"

let renderFlex flexProp =
    let example =
        Html.div [
            prop.className "flex gap-2"
            prop.children [
                Tailwind.divCombine [
                    flexProp
                    prop.className "bg-blue-400 p-2"
                    prop.text (str flexProp)
                ]
                Html.div [
                    prop.className "flex-1 bg-gray-300 p-2"
                    prop.text "flex-1"
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "flex gap-2"
    prop.children [
        Tailwind.divCombine [
            {str flexProp}
            prop.className "bg-blue-400 p-2"
            prop.text "{str flexProp}"
        ]
        Html.div [
            prop.className "flex-1 bg-gray-300 p-2"
            prop.text "flex-1"
        ]
    ]
]"""

    let title =
        Html.text
            "Use flex utilities to control how flex items grow and shrink."
    codedView title code example

[<ReactComponent>]
let FlexView () =
    React.fragment [
        for flexProp in flexStyles do
            renderFlex flexProp
    ]
