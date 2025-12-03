module Docs.Pages.Height

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let heightStyles = [
    height.h0
    height.h4
    height.h8
    height.h16
    height.h32
    height.h64
    height.hAuto
    height.hFull
    height.hScreen
    height.hMin
    height.hMax
    height.hFit
]

let str prop =
    if prop = height.h0 then "height.h0"
    elif prop = height.h4 then "height.h4"
    elif prop = height.h8 then "height.h8"
    elif prop = height.h16 then "height.h16"
    elif prop = height.h32 then "height.h32"
    elif prop = height.h64 then "height.h64"
    elif prop = height.hAuto then "height.hAuto"
    elif prop = height.hFull then "height.hFull"
    elif prop = height.hScreen then "height.hScreen"
    elif prop = height.hMin then "height.hMin"
    elif prop = height.hMax then "height.hMax"
    elif prop = height.hFit then "height.hFit"
    else "unknown"

let renderHeight heightProp =
    let example =
        Html.div [
            prop.className "h-32 bg-gray-200"
            prop.children [
                Tailwind.divCombine [
                    heightProp
                    prop.className "bg-blue-400 w-full"
                    prop.text (str heightProp)
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "h-32 bg-gray-200"
    prop.children [
        Tailwind.divCombine [
            {str heightProp}
            prop.className "bg-blue-400 w-full"
            prop.text "{str heightProp}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use height utilities to set the height of an element."
    codedView title code example

[<ReactComponent>]
let HeightView () =
    React.fragment [
        for heightProp in heightStyles do
            renderHeight heightProp
    ]
