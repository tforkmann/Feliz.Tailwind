module Docs.Pages.BorderWidth

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let borderWidthStyles = [
    borderWidth.borderR
    borderWidth.borderL
    borderWidth.borderT
    borderWidth.borderB
]

let str prop =
    if prop = borderWidth.borderR then "borderWidth.borderR"
    elif prop = borderWidth.borderL then "borderWidth.borderL"
    elif prop = borderWidth.borderT then "borderWidth.borderT"
    elif prop = borderWidth.borderB then "borderWidth.borderB"
    else "unknown"

let renderBorderWidth borderW =
    let example =
        Tailwind.divCombine [
            borderW
            prop.className "p-4 bg-gray-100 border-blue-500"
            prop.text (str borderW)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str borderW}
    prop.className "p-4 bg-gray-100 border-blue-500"
    prop.text "{str borderW}"
]"""

    let title =
        Html.text
            "Use borderWidth to control the width of an element's borders."
    codedView title code example

[<ReactComponent>]
let BorderWidthView () =
    React.fragment [
        for borderW in borderWidthStyles do
            renderBorderWidth borderW
    ]
