module Index

open System
open Elmish
open Fable.React
open Feliz
open Browser.Dom
open Fable.Core.JsInterop

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none

[<ReactComponent>]
let Test () =
    React.fragment [
        Html.h1 "Hello World"
        // Html.divClassed "description" [ Html.text "Using NuGet package command" ]
        // Html.divClassed
        //     "max-w-xl"
        //     [ Daisy.mockupCode [
        //           Html.pre [
        //               mockupCode.prefix "$"
        //               prop.children [
        //                   Html.code "Install-Package Feliz.ChartJS"
        //               ]
        //           ]
        //       ] ]
        // Html.divClassed "description" [ Html.text "or Paket" ]
        // Html.divClassed
        //     "max-w-xl"
        //     [ Daisy.mockupCode [
        //           Html.pre [
        //               mockupCode.prefix "$"
        //               prop.children [
        //                   Html.code "paket add Feliz.ChartJS"
        //               ]
        //           ]
        //       ] ]

        ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [
            style.height 600
            style.width 600
        ]
        prop.children [
            Test()
        ]

        ]