module Docs.Pages.MaxWidth

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let maxWidthStyles = [
    maxWidth.wXs
    maxWidth.wSm
    maxWidth.wMm
    maxWidth.wLg
    maxWidth.wXl
    maxWidth.w2Xl
    maxWidth.wFull
]

let str prop =
    if prop = maxWidth.wXs then "maxWidth.wXs"
    elif prop = maxWidth.wSm then "maxWidth.wSm"
    elif prop = maxWidth.wMm then "maxWidth.wMm"
    elif prop = maxWidth.wLg then "maxWidth.wLg"
    elif prop = maxWidth.wXl then "maxWidth.wXl"
    elif prop = maxWidth.w2Xl then "maxWidth.w2Xl"
    elif prop = maxWidth.wFull then "maxWidth.wFull"
    else "unknown"

let renderMaxWidth maxW =
    let example =
        Tailwind.divCombine [
            maxW
            prop.className "bg-blue-400 p-2"
            prop.text (str maxW)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str maxW}
    prop.className "bg-blue-400 p-2"
    prop.text "{str maxW}"
]"""

    let title =
        Html.text
            "Use maxWidth to set the maximum width of an element."
    codedView title code example

[<ReactComponent>]
let MaxWidthView () =
    React.fragment [
        for maxW in maxWidthStyles do
            renderMaxWidth maxW
    ]
