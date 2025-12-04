module Docs.Pages.BgOpacity

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let bgOpacityStyles = [
    bgOpacity.bgOpacity0
    bgOpacity.bgOpacity25
    bgOpacity.bgOpacity50
    bgOpacity.bgOpacity75
    bgOpacity.bgOpacity100
]

let str prop =
    if prop = bgOpacity.bgOpacity0 then "bgOpacity.bgOpacity0"
    elif prop = bgOpacity.bgOpacity25 then "bgOpacity.bgOpacity25"
    elif prop = bgOpacity.bgOpacity50 then "bgOpacity.bgOpacity50"
    elif prop = bgOpacity.bgOpacity75 then "bgOpacity.bgOpacity75"
    elif prop = bgOpacity.bgOpacity100 then "bgOpacity.bgOpacity100"
    else "unknown"

let renderBgOpacity opacityProp =
    let example =
        Html.div [
            prop.className "bg-gray-200 p-4"
            prop.children [
                Tailwind.divCombine [
                    backgroundColor.bgBlue500
                    opacityProp
                    prop.className "p-4 text-white"
                    prop.text (str opacityProp)
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "bg-gray-200 p-4"
    prop.children [
        Tailwind.divCombine [
            backgroundColor.bgBlue500
            {str opacityProp}
            prop.className "p-4 text-white"
            prop.text "{str opacityProp}"
        ]
    ]
]"""

    let title =
        Html.text
            "Use bgOpacity to control the opacity of an element's background color."
    codedView title code example

[<ReactComponent>]
let BgOpacityView () =
    React.fragment [
        for opacityProp in bgOpacityStyles do
            renderBgOpacity opacityProp
    ]
