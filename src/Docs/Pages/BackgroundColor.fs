module Docs.Pages.BackgroundColor

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let backgroundColorStyles = [
    backgroundColor.bgBlack, "backgroundColor.bgBlack"
    backgroundColor.bgWhite, "backgroundColor.bgWhite"
    backgroundColor.bgSlate500, "backgroundColor.bgSlate500"
    backgroundColor.bgRed500, "backgroundColor.bgRed500"
    backgroundColor.bgOrange500, "backgroundColor.bgOrange500"
    backgroundColor.bgAmber500, "backgroundColor.bgAmber500"
    backgroundColor.bgYellow500, "backgroundColor.bgYellow500"
    backgroundColor.bgLime500, "backgroundColor.bgLime500"
    backgroundColor.bgGreen500, "backgroundColor.bgGreen500"
    backgroundColor.bgEmerald500, "backgroundColor.bgEmerald500"
    backgroundColor.bgTeal500, "backgroundColor.bgTeal500"
    backgroundColor.bgCyan500, "backgroundColor.bgCyan500"
    backgroundColor.bgSky500, "backgroundColor.bgSky500"
    backgroundColor.bgBlue500, "backgroundColor.bgBlue500"
]

let renderBackgroundColor (bgColor, name: string) =
    let example =
        Tailwind.divCombine [
            bgColor
            prop.className "p-4 text-white"
            prop.text name
        ]

    let code =
        $"""Tailwind.divCombine [
    {name}
    prop.className "p-4 text-white"
    prop.text "{name}"
]"""

    let title =
        Html.text
            "Use backgroundColor to set the background color of an element."
    codedView title code example

[<ReactComponent>]
let BackgroundColorView () =
    Html.div [
        prop.className "space-y-4"
        prop.children [
            Html.div [
                prop.className "p-4 bg-blue-50 rounded-lg mb-6"
                prop.children [
                    Html.h3 [
                        prop.className "font-bold text-lg mb-2"
                        prop.text "New in v4.0.2: Complete Color Palette"
                    ]
                    Html.p [
                        prop.text "This release adds all missing Tailwind colors: Gray, Zinc, Neutral, Stone, Indigo, Violet, Purple, Fuchsia, Pink, Rose + special values (bgInherit, bgCurrent, bgTransparent). Total: 247 background colors!"
                    ]
                ]
            ]
            React.fragment [
                for style in backgroundColorStyles do
                    renderBackgroundColor style
            ]
        ]
    ]
