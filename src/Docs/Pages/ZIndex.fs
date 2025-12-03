module Docs.Pages.ZIndex

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let zIndexStyles = [
    zIndex.z0
    zIndex.z10
    zIndex.z20
    zIndex.z30
    zIndex.z40
    zIndex.z50
    zIndex.zAuto
]

let str prop =
    if prop = zIndex.z0 then "zIndex.z0"
    elif prop = zIndex.z10 then "zIndex.z10"
    elif prop = zIndex.z20 then "zIndex.z20"
    elif prop = zIndex.z30 then "zIndex.z30"
    elif prop = zIndex.z40 then "zIndex.z40"
    elif prop = zIndex.z50 then "zIndex.z50"
    elif prop = zIndex.zAuto then "zIndex.zAuto"
    else "unknown"

let renderZIndex zIndexProp =
    let example =
        Html.div [
            prop.className "relative h-24"
            prop.children [
                Tailwind.divCombine [
                    position.absolute
                    zIndexProp
                    prop.className "bg-blue-400 p-2 w-20 h-20"
                    prop.text (str zIndexProp)
                ]
                Html.div [
                    prop.className "absolute bg-red-400 p-2 w-20 h-20 left-8 top-4 z-10"
                    prop.text "z-10 ref"
                ]
            ]
        ]

    let code =
        $"""Html.div [
    prop.className "relative h-24"
    prop.children [
        Tailwind.divCombine [
            position.absolute
            {str zIndexProp}
            prop.className "bg-blue-400 p-2 w-20 h-20"
            prop.text "{str zIndexProp}"
        ]
        Html.div [
            prop.className "absolute bg-red-400 p-2 w-20 h-20 left-8 top-4 z-10"
            prop.text "z-10 ref"
        ]
    ]
]"""

    let title =
        Html.text
            "Use zIndex utilities to control the stack order of an element."
    codedView title code example

[<ReactComponent>]
let ZIndexView () =
    React.fragment [
        for zIndexProp in zIndexStyles do
            renderZIndex zIndexProp
    ]
