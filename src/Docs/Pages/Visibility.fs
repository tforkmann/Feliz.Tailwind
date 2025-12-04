module Docs.Pages.Visibility

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let visibilityStyles = [
    visibility.visible
    visibility.invisible
]

let str prop =
    if prop = visibility.visible then "visibility.visible"
    elif prop = visibility.invisible then "visibility.invisible"
    else "unknown"

let renderVisibility visProp =
    let example =
        Html.div [
            prop.className "flex gap-2"
            prop.children [
                Html.div [
                    prop.className "bg-gray-300 p-2"
                    prop.text "Before"
                ]
                Tailwind.divCombine [
                    visProp
                    prop.className "bg-blue-400 p-2"
                    prop.text (str visProp)
                ]
                Html.div [
                    prop.className "bg-gray-300 p-2"
                    prop.text "After"
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "flex gap-2"
    prop.children [
        Html.div [ prop.className "bg-gray-300 p-2"; prop.text "Before" ]
        Tailwind.divCombine [
            {str visProp}
            prop.className "bg-blue-400 p-2"
            prop.text "{str visProp}"
        ]
        Html.div [ prop.className "bg-gray-300 p-2"; prop.text "After" ]
    ]
]"""

    let title =
        Html.text
            "Use visibility to control the visibility of an element without affecting layout."
    codedView title code example

[<ReactComponent>]
let VisibilityView () =
    React.fragment [
        for visProp in visibilityStyles do
            renderVisibility visProp
    ]
