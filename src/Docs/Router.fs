module Docs.Router

open Browser.Types
open Feliz.Router
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
type Page =
    | Install
    | Use
    | BorderRadius
    | BoxShadow
    | TextAlign

module Page =
    let defaultPage = Page.Install

    let parseFromUrlSegments =
        function
        | [ "use" ] -> Page.Use
        | [ "borderradius" ] -> Page.BorderRadius
        | [ "boxshadow" ] -> Page.BoxShadow
        | [ "textalign" ] -> Page.TextAlign
        | [] -> Page.Install
        | _ -> defaultPage

    let noQueryString segments : string list * (string * string) list = segments, []

    let toUrlSegments =
        function
        | Page.Install -> [] |> noQueryString
        | Page.Use -> [ "use" ] |> noQueryString
        | Page.BorderRadius -> [ "borderradius" ] |> noQueryString
        | Page.BoxShadow -> [ "boxshadow" ] |> noQueryString
        | Page.TextAlign -> [ "textalign" ] |> noQueryString


[<RequireQualifiedAccess>]
module Router =
    let goToUrl (e: MouseEvent) =
        e.preventDefault ()
        let href: string = !!e.currentTarget?attributes?href?value
        Router.navigate href

    let navigatePage (p: Page) =
        p |> Page.toUrlSegments |> Router.navigate

[<RequireQualifiedAccess>]
module Cmd =
    let navigatePage (p: Page) = p |> Page.toUrlSegments |> Cmd.navigate