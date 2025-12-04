module Docs.Pages.BackgroundColor

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let backgroundColorStyles = [
    backgroundColor.bgBlack
    backgroundColor.bgWhite
    backgroundColor.bgRed500
    backgroundColor.bgOrange500
    backgroundColor.bgYellow500
    backgroundColor.bgGreen500
    backgroundColor.bgBlue500
    backgroundColor.bgSlate500
]

let str prop =
    if prop = backgroundColor.bgBlack then "backgroundColor.bgBlack"
    elif prop = backgroundColor.bgWhite then "backgroundColor.bgWhite"
    elif prop = backgroundColor.bgRed500 then "backgroundColor.bgRed500"
    elif prop = backgroundColor.bgOrange500 then "backgroundColor.bgOrange500"
    elif prop = backgroundColor.bgYellow500 then "backgroundColor.bgYellow500"
    elif prop = backgroundColor.bgGreen500 then "backgroundColor.bgGreen500"
    elif prop = backgroundColor.bgBlue500 then "backgroundColor.bgBlue500"
    elif prop = backgroundColor.bgSlate500 then "backgroundColor.bgSlate500"
    else "unknown"

let renderBackgroundColor bgColor =
    let example =
        Tailwind.divCombine [
            bgColor
            prop.className "p-4 text-white"
            prop.text (str bgColor)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str bgColor}
    prop.className "p-4 text-white"
    prop.text "{str bgColor}"
]"""

    let title =
        Html.text
            "Use backgroundColor to set the background color of an element."
    codedView title code example

[<ReactComponent>]
let BackgroundColorView () =
    React.fragment [
        for bgColor in backgroundColorStyles do
            renderBackgroundColor bgColor
    ]
