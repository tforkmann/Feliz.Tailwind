module Docs.Pages.Margin

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let marginStyles = [
    margin.m0
    margin.m1
    margin.m2
    margin.m4
    margin.m8
    margin.mx2
    margin.my2
    margin.mt4
    margin.mr4
    margin.mb4
    margin.ml4
    margin.mAuto
    margin.mxAuto
]

let str prop =
    if prop = margin.m0 then "margin.m0"
    elif prop = margin.m1 then "margin.m1"
    elif prop = margin.m2 then "margin.m2"
    elif prop = margin.m4 then "margin.m4"
    elif prop = margin.m8 then "margin.m8"
    elif prop = margin.mx2 then "margin.mx2"
    elif prop = margin.my2 then "margin.my2"
    elif prop = margin.mt4 then "margin.mt4"
    elif prop = margin.mr4 then "margin.mr4"
    elif prop = margin.mb4 then "margin.mb4"
    elif prop = margin.ml4 then "margin.ml4"
    elif prop = margin.mAuto then "margin.mAuto"
    elif prop = margin.mxAuto then "margin.mxAuto"
    else "unknown"

let renderMargin marginProp =
    let example =
        Html.div [
            prop.className "bg-gray-200 inline-block"
            prop.children [
                Tailwind.divCombine [
                    marginProp
                    prop.className "bg-blue-400 p-4"
                    prop.text (str marginProp)
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "bg-gray-200 inline-block"
    prop.children [
        Tailwind.divCombine [
            {str marginProp}
            prop.className "bg-blue-400 p-4"
            prop.text "{str marginProp}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use margin utilities to control the margin of an element."
    codedView title code example

[<ReactComponent>]
let MarginView () =
    React.fragment [
        for marginProp in marginStyles do
            renderMargin marginProp
    ]
