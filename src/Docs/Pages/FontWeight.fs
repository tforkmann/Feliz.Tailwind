module Docs.Pages.FontWeight

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let fontWeightStyles = [
    fontWeight.fontThin
    fontWeight.fontExtraLight
    fontWeight.fontLight
    fontWeight.fontNormal
    fontWeight.fontMedium
    fontWeight.fontSemibold
    fontWeight.fontBold
    fontWeight.fontExtraBold
    fontWeight.fontBlack
]

let str prop =
    if prop = fontWeight.fontThin then "fontWeight.fontThin"
    elif prop = fontWeight.fontExtraLight then "fontWeight.fontExtraLight"
    elif prop = fontWeight.fontLight then "fontWeight.fontLight"
    elif prop = fontWeight.fontNormal then "fontWeight.fontNormal"
    elif prop = fontWeight.fontMedium then "fontWeight.fontMedium"
    elif prop = fontWeight.fontSemibold then "fontWeight.fontSemibold"
    elif prop = fontWeight.fontBold then "fontWeight.fontBold"
    elif prop = fontWeight.fontExtraBold then "fontWeight.fontExtraBold"
    elif prop = fontWeight.fontBlack then "fontWeight.fontBlack"
    else "unknown"

let renderFontWeight weightProp =
    let example =
        Tailwind.divCombine [
            weightProp
            prop.className "text-lg"
            prop.text (str weightProp)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str weightProp}
    prop.className "text-lg"
    prop.text "{str weightProp}"
]"""

    let title =
        Html.text
            "Use fontWeight to control the font weight of text."
    codedView title code example

[<ReactComponent>]
let FontWeightView () =
    React.fragment [
        for weightProp in fontWeightStyles do
            renderFontWeight weightProp
    ]
