module Docs.Pages.Overflow

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let overflowStyles = [
    overflow.overflowAuto
    overflow.overflowHidden
    overflow.overflowClip
    overflow.overflowVisible
    overflow.overflowScroll
    overflow.overflowXAuto
    overflow.overflowYAuto
]

let str prop =
    if prop = overflow.overflowAuto then "overflow.overflowAuto"
    elif prop = overflow.overflowHidden then "overflow.overflowHidden"
    elif prop = overflow.overflowClip then "overflow.overflowClip"
    elif prop = overflow.overflowVisible then "overflow.overflowVisible"
    elif prop = overflow.overflowScroll then "overflow.overflowScroll"
    elif prop = overflow.overflowXAuto then "overflow.overflowXAuto"
    elif prop = overflow.overflowYAuto then "overflow.overflowYAuto"
    else "unknown"

let renderOverflow overflowProp =
    let example =
        Tailwind.divCombine [
            overflowProp
            prop.className "h-24 w-48 bg-gray-200"
            prop.children [
                Html.div [
                    prop.className "bg-blue-400 p-2 w-64 h-32"
                    prop.text (str overflowProp + " - This is a long text that will overflow the container to demonstrate the overflow behavior.")
                ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    {str overflowProp}
    prop.className "h-24 w-48 bg-gray-200"
    prop.children [
        Html.div [
            prop.className "bg-blue-400 p-2 w-64 h-32"
            prop.text "Long overflowing content..."
        ]
    ]
]"""

    let title =
        Html.text
            "Use overflow utilities to control how content that overflows an element is handled."
    codedView title code example

[<ReactComponent>]
let OverflowView () =
    React.fragment [
        for overflowProp in overflowStyles do
            renderOverflow overflowProp
    ]
