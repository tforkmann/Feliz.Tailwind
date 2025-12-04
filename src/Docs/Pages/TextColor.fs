module Docs.Pages.TextColor

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let textColorStyles = [
    textColor.black
    textColor.white
    textColor.red500
    textColor.orange500
    textColor.yellow500
    textColor.green500
    textColor.blue500
]

let str prop =
    if prop = textColor.black then "textColor.black"
    elif prop = textColor.white then "textColor.white"
    elif prop = textColor.red500 then "textColor.red500"
    elif prop = textColor.orange500 then "textColor.orange500"
    elif prop = textColor.yellow500 then "textColor.yellow500"
    elif prop = textColor.green500 then "textColor.green500"
    elif prop = textColor.blue500 then "textColor.blue500"
    else "unknown"

let renderTextColor colorProp =
    let bgClass =
        if colorProp = textColor.white then "bg-gray-800" else "bg-gray-100"
    let example =
        Tailwind.divCombine [
            colorProp
            prop.className $"p-4 text-lg {bgClass}"
            prop.text (str colorProp)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str colorProp}
    prop.className "p-4 text-lg"
    prop.text "{str colorProp}"
]"""

    let title =
        Html.text
            "Use textColor to control the text color of an element."
    codedView title code example

[<ReactComponent>]
let TextColorView () =
    React.fragment [
        for colorProp in textColorStyles do
            renderTextColor colorProp
    ]
