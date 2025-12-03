module Docs.Pages.FlexDirection

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let flexDirectionStyles = [
    flexDirection.flexRow
    flexDirection.flexRowReserve
    flexDirection.flexCol
    flexDirection.flexColReserve
]

let str prop =
    if prop = flexDirection.flexRow then "flexDirection.flexRow"
    elif prop = flexDirection.flexRowReserve then "flexDirection.flexRowReserve"
    elif prop = flexDirection.flexCol then "flexDirection.flexCol"
    elif prop = flexDirection.flexColReserve then "flexDirection.flexColReserve"
    else "unknown"

let renderFlexDirection flexDir =
    let example =
        Tailwind.divCombine [
            display.flex
            flexDir
            prop.className "gap-2 bg-gray-100 p-4"
            prop.children [
                Tailwind.divCombine [
                    prop.text "1"
                    prop.className "w-10 h-10 bg-blue-300 flex items-center justify-center" ]
                Tailwind.divCombine [
                    prop.text "2"
                    prop.className "w-10 h-10 bg-blue-400 flex items-center justify-center" ]
                Tailwind.divCombine [
                    prop.text "3"
                    prop.className "w-10 h-10 bg-blue-500 flex items-center justify-center" ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    display.flex
    {str flexDir}
    prop.className "gap-2 bg-gray-100 p-4"
    prop.children [
        Tailwind.divCombine [
            prop.text "1"
            prop.className "w-10 h-10 bg-blue-300" ]
        Tailwind.divCombine [
            prop.text "2"
            prop.className "w-10 h-10 bg-blue-400" ]
        Tailwind.divCombine [
            prop.text "3"
            prop.className "w-10 h-10 bg-blue-500" ]
    ]
]"""

    let title =
        Html.text
            "Use flexDirection to control the direction of flex items."
    codedView title code example

[<ReactComponent>]
let FlexDirectionView () =
    React.fragment [
        for flexDir in flexDirectionStyles do
            renderFlexDirection flexDir
    ]
