module Docs.Pages.Position

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let positionStyles = [
    position.static'
    position.fixed'
    position.absolute
    position.relative
    position.sticky
]

let str prop =
    if prop = position.static' then "position.static'"
    elif prop = position.fixed' then "position.fixed'"
    elif prop = position.absolute then "position.absolute"
    elif prop = position.relative then "position.relative"
    elif prop = position.sticky then "position.sticky"
    else "unknown"

let renderPosition positionProp =
    let example =
        Html.div [
            prop.className "relative h-32 bg-gray-200"
            prop.children [
                Tailwind.divCombine [
                    if positionProp <> position.fixed' && positionProp <> position.sticky then
                        positionProp
                    prop.className "bg-blue-400 p-2"
                    prop.text (str positionProp)
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "relative h-32 bg-gray-200"
    prop.children [
        Tailwind.divCombine [
            {str positionProp}
            prop.className "bg-blue-400 p-2"
            prop.text "{str positionProp}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use position utilities to control how an element is positioned in the DOM."
    codedView title code example

[<ReactComponent>]
let PositionView () =
    React.fragment [
        for positionProp in positionStyles do
            renderPosition positionProp
    ]
