module Docs.Pages.Padding

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let paddingStyles = [
    padding.p0
    padding.p1
    padding.p2
    padding.p4
    padding.p8
    padding.px2
    padding.py2
    padding.pt4
    padding.pr4
    padding.pb4
    padding.pl4
]

let str prop =
    if prop = padding.p0 then "padding.p0"
    elif prop = padding.p1 then "padding.p1"
    elif prop = padding.p2 then "padding.p2"
    elif prop = padding.p4 then "padding.p4"
    elif prop = padding.p8 then "padding.p8"
    elif prop = padding.px2 then "padding.px2"
    elif prop = padding.py2 then "padding.py2"
    elif prop = padding.pt4 then "padding.pt4"
    elif prop = padding.pr4 then "padding.pr4"
    elif prop = padding.pb4 then "padding.pb4"
    elif prop = padding.pl4 then "padding.pl4"
    else "unknown"

let renderPadding paddingProp =
    let example =
        Tailwind.divCombine [
            paddingProp
            prop.className "bg-blue-400 inline-block"
            prop.children [
                Html.div [
                    prop.className "bg-white"
                    prop.text (str paddingProp)
                ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    {str paddingProp}
    prop.className "bg-blue-400 inline-block"
    prop.children [
        Html.div [
            prop.className "bg-white"
            prop.text "{str paddingProp}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use padding utilities to control the padding of an element."
    codedView title code example

[<ReactComponent>]
let PaddingView () =
    React.fragment [
        for paddingProp in paddingStyles do
            renderPadding paddingProp
    ]
