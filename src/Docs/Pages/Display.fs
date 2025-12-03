module Docs.Pages.Display

open Feliz
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let displayStyles = [
    display.block
    display.inlineBlock
    display.inline'
    display.flex
    display.inlineFlex
    display.grid
    display.inlineGrid
    display.hidden
    display.contents
    display.flowRoot
    display.table
]

let str prop =
    if prop = display.block then "display.block"
    elif prop = display.inlineBlock then "display.inlineBlock"
    elif prop = display.inline' then "display.inline'"
    elif prop = display.flex then "display.flex"
    elif prop = display.inlineFlex then "display.inlineFlex"
    elif prop = display.grid then "display.grid"
    elif prop = display.inlineGrid then "display.inlineGrid"
    elif prop = display.hidden then "display.hidden"
    elif prop = display.contents then "display.contents"
    elif prop = display.flowRoot then "display.flowRoot"
    elif prop = display.table then "display.table"
    else "unknown"

let renderDisplay displayProp =
    let example =
        Tailwind.divCombine [
            displayProp
            prop.className "bg-blue-100 p-4"
            prop.children [
                Html.span [ prop.text "Element with " ]
                Html.span [ prop.className "font-bold"; prop.text (str displayProp) ]
            ]
        ]

    let code =
        $"""Tailwind.divCombine [
    {str displayProp}
    prop.className "bg-blue-100 p-4"
    prop.children [
        Html.span [ prop.text "Element with " ]
        Html.span [ prop.className "font-bold"; prop.text "{str displayProp}" ]
    ]
]"""

    let title =
        Html.text
            "Use display utilities to control the display box type of an element."
    codedView title code example

[<ReactComponent>]
let DisplayView () =
    React.fragment [
        for displayProp in displayStyles do
            renderDisplay displayProp
    ]
