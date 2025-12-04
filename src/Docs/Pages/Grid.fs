module Docs.Pages.Grid

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let gridStyles = [
    grid.``cols-1``
    grid.``cols-2``
    grid.``cols-3``
    grid.``cols-4``
    grid.``cols-6``
    grid.``cols-12``
]

let str prop =
    if prop = grid.``cols-1`` then "grid.``cols-1``"
    elif prop = grid.``cols-2`` then "grid.``cols-2``"
    elif prop = grid.``cols-3`` then "grid.``cols-3``"
    elif prop = grid.``cols-4`` then "grid.``cols-4``"
    elif prop = grid.``cols-6`` then "grid.``cols-6``"
    elif prop = grid.``cols-12`` then "grid.``cols-12``"
    else "unknown"

let renderGrid gridProp =
    let example =
        Tailwind.divCombine [
            display.grid
            gridProp
            prop.className "gap-2"
            prop.children [
                for i in 1..6 do
                    Html.div [
                        prop.className "bg-blue-400 p-2 text-white text-center"
                        prop.text (string i)
                    ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    display.grid
    {str gridProp}
    prop.className "gap-2"
    prop.children [
        for i in 1..6 do
            Html.div [
                prop.className "bg-blue-400 p-2 text-white text-center"
                prop.text (string i)
            ]
    ]
]"""

    let title =
        Html.text
            "Use grid utilities to create grid layouts with specified column counts."
    codedView title code example

[<ReactComponent>]
let GridView () =
    React.fragment [
        for gridProp in gridStyles do
            renderGrid gridProp
    ]
