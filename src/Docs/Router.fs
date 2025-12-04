module Docs.Router

open Browser.Types
open Feliz.Router
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
type Page =
    | Install
    | Use
    | AlignItems
    | BackgroundColor
    | BgOpacity
    | BorderRadius
    | BorderWidth
    | BoxShadow
    | Display
    | Flex
    | FlexDirection
    | FlexGrow
    | FlexShrink
    | FontSize
    | FontWeight
    | Gap
    | Grid
    | Height
    | JustifyContent
    | JustifyItems
    | Margin
    | MaxHeight
    | MaxWidth
    | MinHeight
    | Opacity
    | Outline
    | Overflow
    | Padding
    | Position
    | TextAlign
    | TextColor
    | Visibility
    | Width
    | ZIndex

module Page =
    let defaultPage = Page.Install

    let parseFromUrlSegments =
        function
        | [ "use" ] -> Page.Use
        | [ "alignitems" ] -> Page.AlignItems
        | [ "backgroundcolor" ] -> Page.BackgroundColor
        | [ "bgopacity" ] -> Page.BgOpacity
        | [ "borderradius" ] -> Page.BorderRadius
        | [ "borderwidth" ] -> Page.BorderWidth
        | [ "boxshadow" ] -> Page.BoxShadow
        | [ "display" ] -> Page.Display
        | [ "flex" ] -> Page.Flex
        | [ "flexdirection" ] -> Page.FlexDirection
        | [ "flexgrow" ] -> Page.FlexGrow
        | [ "flexshrink" ] -> Page.FlexShrink
        | [ "fontsize" ] -> Page.FontSize
        | [ "fontweight" ] -> Page.FontWeight
        | [ "gap" ] -> Page.Gap
        | [ "grid" ] -> Page.Grid
        | [ "height" ] -> Page.Height
        | [ "justifycontent" ] -> Page.JustifyContent
        | [ "justifyitems" ] -> Page.JustifyItems
        | [ "margin" ] -> Page.Margin
        | [ "maxheight" ] -> Page.MaxHeight
        | [ "maxwidth" ] -> Page.MaxWidth
        | [ "minheight" ] -> Page.MinHeight
        | [ "opacity" ] -> Page.Opacity
        | [ "outline" ] -> Page.Outline
        | [ "overflow" ] -> Page.Overflow
        | [ "padding" ] -> Page.Padding
        | [ "position" ] -> Page.Position
        | [ "textalign" ] -> Page.TextAlign
        | [ "textcolor" ] -> Page.TextColor
        | [ "visibility" ] -> Page.Visibility
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
        | Page.BackgroundColor -> [ "backgroundcolor" ] |> noQueryString
        | Page.BgOpacity -> [ "bgopacity" ] |> noQueryString
        | Page.BorderRadius -> [ "borderradius" ] |> noQueryString
        | Page.BorderWidth -> [ "borderwidth" ] |> noQueryString
        | Page.BoxShadow -> [ "boxshadow" ] |> noQueryString
        | Page.Display -> [ "display" ] |> noQueryString
        | Page.Flex -> [ "flex" ] |> noQueryString
        | Page.FlexDirection -> [ "flexdirection" ] |> noQueryString
        | Page.FlexGrow -> [ "flexgrow" ] |> noQueryString
        | Page.FlexShrink -> [ "flexshrink" ] |> noQueryString
        | Page.FontSize -> [ "fontsize" ] |> noQueryString
        | Page.FontWeight -> [ "fontweight" ] |> noQueryString
        | Page.Gap -> [ "gap" ] |> noQueryString
        | Page.Grid -> [ "grid" ] |> noQueryString
        | Page.Height -> [ "height" ] |> noQueryString
        | Page.JustifyContent -> [ "justifycontent" ] |> noQueryString
        | Page.JustifyItems -> [ "justifyitems" ] |> noQueryString
        | Page.Margin -> [ "margin" ] |> noQueryString
        | Page.MaxHeight -> [ "maxheight" ] |> noQueryString
        | Page.MaxWidth -> [ "maxwidth" ] |> noQueryString
        | Page.MinHeight -> [ "minheight" ] |> noQueryString
        | Page.Opacity -> [ "opacity" ] |> noQueryString
        | Page.Outline -> [ "outline" ] |> noQueryString
        | Page.Overflow -> [ "overflow" ] |> noQueryString
        | Page.Padding -> [ "padding" ] |> noQueryString
        | Page.Position -> [ "position" ] |> noQueryString
        | Page.TextAlign -> [ "textalign" ] |> noQueryString
        | Page.TextColor -> [ "textcolor" ] |> noQueryString
        | Page.Visibility -> [ "visibility" ] |> noQueryString
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