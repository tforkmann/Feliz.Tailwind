module Docs.Pages.AlignItems

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let alignItemsStyles = [
    alignItems.itemsStart
    alignItems.itemsEnd
    alignItems.itemsCenter
    alignItems.itemsBaseline
    alignItems.itemsStretch
]

let str prop =
    if prop = alignItems.itemsStart then "alignItems.itemsStart"
    elif prop = alignItems.itemsEnd then "alignItems.itemsEnd"
    elif prop = alignItems.itemsCenter then "alignItems.itemsCenter"
    elif prop = alignItems.itemsBaseline then "alignItems.itemsBaseline"
    elif prop = alignItems.itemsStretch then "alignItems.itemsStretch"
    else "unknown"

let renderAlignItems alignItem =
    let example =
        Tailwind.divCombine [
            display.flex
            alignItem
            prop.className "h-24 bg-gray-100"
            prop.children [
                Tailwind.divCombine [
                    prop.text "1"
                    prop.className "w-8 h-8 bg-blue-300" ]
                Tailwind.divCombine [
                    prop.text "2"
                    prop.className "w-8 h-12 bg-blue-400" ]
                Tailwind.divCombine [
                    prop.text "3"
                    prop.className "w-8 h-6 bg-blue-500" ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    display.flex
    {str alignItem}
    prop.className "h-24 bg-gray-100"
    prop.children [
        Tailwind.divCombine [
            prop.text "1"
            prop.className "w-8 h-8 bg-blue-300" ]
        Tailwind.divCombine [
            prop.text "2"
            prop.className "w-8 h-12 bg-blue-400" ]
        Tailwind.divCombine [
            prop.text "3"
            prop.className "w-8 h-6 bg-blue-500" ]
    ]
]"""

    let title =
        Html.text
            "Use alignItems to control the alignment of flex items on the cross axis."
    codedView title code example

[<ReactComponent>]
let AlignItemsView () =
    React.fragment [
        for alignItem in alignItemsStyles do
            renderAlignItems alignItem
    ]
