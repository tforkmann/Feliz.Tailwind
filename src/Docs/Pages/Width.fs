module Docs.Pages.Width

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let widthStyles = [
    width.w0
    width.w4
    width.w8
    width.w16
    width.w32
    width.w64
    width.wAuto
    width.wFull
    width.wScreen
    width.wMin
    width.wMax
    width.wFit
]

let str prop =
    if prop = width.w0 then "width.w0"
    elif prop = width.w4 then "width.w4"
    elif prop = width.w8 then "width.w8"
    elif prop = width.w16 then "width.w16"
    elif prop = width.w32 then "width.w32"
    elif prop = width.w64 then "width.w64"
    elif prop = width.wAuto then "width.wAuto"
    elif prop = width.wFull then "width.wFull"
    elif prop = width.wScreen then "width.wScreen"
    elif prop = width.wMin then "width.wMin"
    elif prop = width.wMax then "width.wMax"
    elif prop = width.wFit then "width.wFit"
    else "unknown"

let renderWidth widthProp =
    let example =
        Tailwind.divCombine [
            widthProp
            prop.className "bg-blue-400 h-8"
            prop.text (str widthProp)
        ]

    let code =
        $"""Tailwind.divCombine [
    {str widthProp}
    prop.className "bg-blue-400 h-8"
    prop.text "{str widthProp}"
]"""

    let title =
        Html.text
            "Use width utilities to set the width of an element."
    codedView title code example

[<ReactComponent>]
let WidthView () =
    React.fragment [
        for widthProp in widthStyles do
            renderWidth widthProp
    ]
