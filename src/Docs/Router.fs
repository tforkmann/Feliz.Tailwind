module Docs.Router

open Browser.Types
open Feliz.Router
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
type Page =
    | Install
    | Use
    | AlignItems
    | BorderRadius
    | BoxShadow
    | Display
    | FlexDirection
    | FontSize
    | Height
    | JustifyContent
    | JustifyItems
    | Margin
    | Opacity
    | Overflow
    | Padding
    | Position
    | TextAlign
    | Width
    | ZIndex

module Page =
    let defaultPage = Page.Install

    let parseFromUrlSegments =
        function
        | [ "use" ] -> Page.Use
        | [ "alignitems" ] -> Page.AlignItems
        | [ "borderradius" ] -> Page.BorderRadius
        | [ "boxshadow" ] -> Page.BoxShadow
        | [ "display" ] -> Page.Display
        | [ "flexdirection" ] -> Page.FlexDirection
        | [ "fontsize" ] -> Page.FontSize
        | [ "height" ] -> Page.Height
        | [ "justifycontent" ] -> Page.JustifyContent
        | [ "justifyitems" ] -> Page.JustifyItems
        | [ "margin" ] -> Page.Margin
        | [ "opacity" ] -> Page.Opacity
        | [ "overflow" ] -> Page.Overflow
        | [ "padding" ] -> Page.Padding
        | [ "position" ] -> Page.Position
        | [ "textalign" ] -> Page.TextAlign
        | [ "width" ] -> Page.Width
        | [ "zindex" ] -> Page.ZIndex
        | [] -> Page.Install
        | _ -> defaultPage

    let noQueryString segments : string list * (string * string) list = segments, []

    let toUrlSegments =
        function
        | Page.Install -> [] |> noQueryString
        | Page.Use -> [ "use" ] |> noQueryString
        | Page.AlignItems -> [ "alignitems" ] |> noQueryString
        | Page.BorderRadius -> [ "borderradius" ] |> noQueryString
        | Page.BoxShadow -> [ "boxshadow" ] |> noQueryString
        | Page.Display -> [ "display" ] |> noQueryString
        | Page.FlexDirection -> [ "flexdirection" ] |> noQueryString
        | Page.FontSize -> [ "fontsize" ] |> noQueryString
        | Page.Height -> [ "height" ] |> noQueryString
        | Page.JustifyContent -> [ "justifycontent" ] |> noQueryString
        | Page.JustifyItems -> [ "justifyitems" ] |> noQueryString
        | Page.Margin -> [ "margin" ] |> noQueryString
        | Page.Opacity -> [ "opacity" ] |> noQueryString
        | Page.Overflow -> [ "overflow" ] |> noQueryString
        | Page.Padding -> [ "padding" ] |> noQueryString
        | Page.Position -> [ "position" ] |> noQueryString
        | Page.TextAlign -> [ "textalign" ] |> noQueryString
        | Page.Width -> [ "width" ] |> noQueryString
        | Page.ZIndex -> [ "zindex" ] |> noQueryString

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