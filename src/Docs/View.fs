module Docs.View

open Feliz
open Router
open Elmish
open SharedView
open Feliz.Tailwind
open Feliz.Tailwind.Operators

type Msg =
    | UrlChanged of Page
    | SetTheme of string

type State = { Page: Page; Theme: string }

let init () =
    let nextPage = Router.currentUrl () |> Page.parseFromUrlSegments
    { Page = nextPage; Theme = "light" }, Cmd.navigatePage nextPage

let update (msg: Msg) (state: State) : State * Cmd<Msg> =
    match msg with
    | UrlChanged page -> { state with Page = page }, Cmd.none
    | SetTheme theme -> { state with Theme = theme }, Cmd.none

let private rightSide state dispatch (title: string) (docLink: string) elm =

    Tailwind.flex [

    Html.div [  padding.px5
                padding.py5
                prop.children [ Html.h2 [   textColor.blue600
                                            margin.my6
                                            fontWeight.fontBold
                                            fontSize.text5Xl
                                            prop.children [ Html.text title
                                                            Html.button [
                                                                margin.ml2
                                                                outline.outline
                                                                padding.px3
                                                                prop.href
                                                                    $"https://Tailwind.com{docLink}"
                                                                prop.children [ Html.text
                                                                                    "Tailwind docs" ] ] ] ]
                                elm ] ] ]

let private leftSide (p: Page) =
    let miBadge (b: string) (t: string) (mp: Page) =
        Html.li [ Html.a [ prop.href mp
                           prop.onClick Router.goToUrl

                           // if p = mp then (menuItem.active ++ prop.className "justify-between")
                           // else prop.className "justify-between"
                           prop.children [ Html.span t
                                           Html.span [ prop.className "badge"
                                                       prop.text b ] ] ] ]

    let mi (t: string) (mp: Page) =
        Html.li [ Html.a [
                           // if p = mp then menuItem.active
                           prop.text t
                           prop.href mp
                           prop.onClick Router.goToUrl ] ]

    Tailwind.flex [
                    // Tailwind.drawerOverlay [ prop.htmlFor "main-menu" ]
                    Html.aside [
                                 display.flex
                                 flexDirection.flexCol
                                 borderWidth.borderR
                                 width.w80
                                 backgroundColor.bgSlate100
                                //  prop.className "text-base-content"
                                 prop.children [ Html.div [
                                                    //  "font-title"
                                                    padding.px5
                                                    padding.py5
                                                    fontWeight.fontBold
                                                    fontSize.text3Xl
                                                    display.inlineBlock
                                                    prop.children [
                                                       Html.span [
                                                                   // color.textPrimary
                                                                   prop.text "Feliz." ]
                                                       Html.text "Tailwind"
                                                       Html.a [ prop.href
                                                                    "https://www.nuget.org/packages/Feliz.Tailwind"
                                                                prop.children [ Html.img [ prop.src
                                                                                               "https://img.shields.io/nuget/v/Feliz.Tailwind.svg?style=flat-square" ] ] ] ] ]
                                                 Tailwind.flex [
                                                                 flexDirection.flexCol
                                                                 padding.p4
                                                                 padding.pt0
                                                                 prop.children [ Html.div [ Html.span "Docs" ]
                                                                                 mi "Install" Page.Install
                                                                                 mi "Use" Page.Use ] ]
                                                 Tailwind.flex [
                                                                 // menu.compact
                                                                 flexDirection.flexCol
                                                                 padding.p4
                                                                 padding.pt0
                                                                 prop.children [ Html.div [ Html.span "Borders" ]
                                                                                 mi "BorderRadius" Page.BorderRadius
                                                                                 // miBadge "updated" "Divider" Page.Divider

                                                                                  ] ] ] ] ]

let private inLayout state dispatch (title: string) (docLink: string) (p: Page) (elm: ReactElement) =
    Tailwind.flex [ height.hScreen
                    backgroundColor.bgWhite
                    fontSize.text3Xl
                    prop.children [ Tailwind.flex [ prop.children [
                                                                    // Tailwind.drawerToggle [ prop.id "main-menu" ]
                                                                    leftSide p
                                                                    rightSide state dispatch title docLink elm
                                                                     ] ] ] ]



[<ReactComponent>]
let AppView (state: State) (dispatch: Msg -> unit) =

    let title, docLink, content =
        match state.Page with
        | Page.Install -> "Installation", "/docs/install", Pages.Install.InstallView()
        | Page.Use -> "How to use", "/docs/use", Pages.Use.UseView()
        | Page.BorderRadius -> "BorderRadius", "/borders/borderradius", Pages.BorderRadius.BorderRadiusView()


    React.router [ router.hashMode
                   router.onUrlChanged (
                       Page.parseFromUrlSegments
                       >> UrlChanged
                       >> dispatch
                   )
                   router.children [ content
                                     |> inLayout state dispatch title docLink state.Page ] ]