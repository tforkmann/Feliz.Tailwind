module Docs.View

open Feliz
open Router
open Elmish
open SharedView
open Feliz.DaisyUI
open Feliz.DaisyUI.Operators

type Msg =
    | UrlChanged of Page
    | SetTheme of string

type State = { Page: Page; Theme: string }

let init () =
    let nextPage = Router.currentUrl () |> Page.parseFromUrlSegments
    { Page = nextPage; Theme = "corporate" }, Cmd.navigatePage nextPage

let update (msg: Msg) (state: State) : State * Cmd<Msg> =
    match msg with
    | UrlChanged page -> { state with Page = page }, Cmd.none
    | SetTheme theme -> { state with Theme = theme }, Cmd.none

let private rightSide state dispatch (title: string) (docLink: string) elm =
    Daisy.drawerContent [
        Daisy.navbar [
            Daisy.navbarStart [
                Html.divClassed
                    "lg:hidden"
                    [ Daisy.button.label [
                          button.square
                          button.ghost
                          prop.htmlFor "main-menu"
                          prop.children [
                              Svg.svg [
                                  svg.viewBox (0, 0, 24, 24)
                                  svg.className "inline-block w-6 h-6 stroke-current"
                                  svg.children [
                                      Svg.path [
                                          svg.d "M4 6h16M4 12h16M4 18h16"
                                          svg.strokeWidth 2
                                      ]
                                  ]
                              ]
                          ]
                      ] ]
            ]
        ]

        Html.divClassed
            "px-5 py-5"
            [ Html.h2 [
                  color.textPrimary
                  ++ prop.className "my-6 text-5xl font-bold"
                  prop.text title
              ]
              elm ]
    ]

let private leftSide (p: Page) =
    let mi (t: string) (mp: Page) =
        Html.li [
            Html.a [
                if p = mp then menuItem.active
                prop.text t
                prop.href mp
                prop.onClick Router.goToUrl
            ]
        ]

    Daisy.drawerSide [
        Daisy.drawerOverlay [
            prop.htmlFor "main-menu"
        ]
        Html.aside [
            prop.className "flex flex-col border-r w-80 bg-base-100 text-base-content"
            prop.children [
                Html.divClassed
                    "inline-block text-3xl font-title px-5 py-5 font-bold"
                    [ Html.span [
                          color.textPrimary
                          prop.text "Feliz.Tailwind"
                      ]
                      Html.a [
                          prop.href "https://www.nuget.org/packages/Feliz.Tailwind"
                          prop.children [
                              Html.img [
                                  prop.src "https://img.shields.io/nuget/v/Feliz.Tailwind.svg?style=flat-square"
                              ]
                          ]
                      ] ]
                Daisy.menu [
                    menu.md
                    prop.className "flex flex-col p-4 pt-0"
                    prop.children [
                        Daisy.menuTitle [ Html.span "Docs" ]
                        mi "Install" Page.Install
                        mi "Use" Page.Use
                        Daisy.menuTitle [ Html.span "Layout" ]
                        mi "Display" Page.Display
                        mi "Overflow" Page.Overflow
                        mi "Position" Page.Position
                        mi "ZIndex" Page.ZIndex
                        Daisy.menuTitle [ Html.span "Flexbox & Grid" ]
                        mi "AlignItems" Page.AlignItems
                        mi "FlexDirection" Page.FlexDirection
                        mi "JustifyContent" Page.JustifyContent
                        mi "JustifyItems" Page.JustifyItems
                        Daisy.menuTitle [ Html.span "Spacing" ]
                        mi "Margin" Page.Margin
                        mi "Padding" Page.Padding
                        Daisy.menuTitle [ Html.span "Sizing" ]
                        mi "Width" Page.Width
                        mi "Height" Page.Height
                        Daisy.menuTitle [ Html.span "Typography" ]
                        mi "FontSize" Page.FontSize
                        mi "TextAlign" Page.TextAlign
                        Daisy.menuTitle [ Html.span "Borders" ]
                        mi "BorderRadius" Page.BorderRadius
                        Daisy.menuTitle [ Html.span "Effects" ]
                        mi "BoxShadow" Page.BoxShadow
                        mi "Opacity" Page.Opacity
                        ]
                ]
            ]
        ]
    ]

let private inLayout state dispatch (title: string) (docLink: string) (p: Page) (elm: ReactElement) =
    Html.div [
        prop.className "bg-base-100 text-base-content h-screen"
        theme.custom state.Theme
        prop.children [
            Daisy.drawer [
                prop.className "lg:drawer-open"
                prop.children [
                    Daisy.drawerToggle [
                        prop.id "main-menu"
                    ]
                    rightSide state dispatch title docLink elm
                    leftSide p
                ]
            ]
        ]
    ]

[<ReactComponent>]
let AppView (state: State) (dispatch: Msg -> unit) =

    let title, docLink, content =
        match state.Page with
        | Page.Install -> "Installation", "/docs/install", Pages.Install.InstallView()
        | Page.Use -> "How to use", "/docs/use", Pages.Use.UseView()
        | Page.AlignItems -> "AlignItems", "/docs/alignitems", Pages.AlignItems.AlignItemsView()
        | Page.BorderRadius -> "BorderRadius", "/docs/borderradius", Pages.BorderRadius.BorderRadiusView()
        | Page.BoxShadow -> "BoxShadow", "/docs/boxshadow", Pages.BoxShadow.BoxShadowView()
        | Page.Display -> "Display", "/docs/display", Pages.Display.DisplayView()
        | Page.FlexDirection -> "FlexDirection", "/docs/flexdirection", Pages.FlexDirection.FlexDirectionView()
        | Page.FontSize -> "FontSize", "/docs/fontsize", Pages.FontSize.FontSizeView()
        | Page.Height -> "Height", "/docs/height", Pages.Height.HeightView()
        | Page.JustifyContent -> "JustifyContent", "/docs/justifycontent", Pages.JustifyContent.JustifyContentView()
        | Page.JustifyItems -> "JustifyItems", "/docs/justifyitems", Pages.JustifyItems.JustifyItemsView()
        | Page.Margin -> "Margin", "/docs/margin", Pages.Margin.MarginView()
        | Page.Opacity -> "Opacity", "/docs/opacity", Pages.Opacity.OpacityView()
        | Page.Overflow -> "Overflow", "/docs/overflow", Pages.Overflow.OverflowView()
        | Page.Padding -> "Padding", "/docs/padding", Pages.Padding.PaddingView()
        | Page.Position -> "Position", "/docs/position", Pages.Position.PositionView()
        | Page.TextAlign -> "TextAlign", "/docs/textalign", Pages.TextAlign.TextAlignView()
        | Page.Width -> "Width", "/docs/width", Pages.Width.WidthView()
        | Page.ZIndex -> "ZIndex", "/docs/zindex", Pages.ZIndex.ZIndexView()

    React.router [
        router.hashMode
        router.onUrlChanged (
            Page.parseFromUrlSegments
            >> UrlChanged
            >> dispatch
        )
        router.children [
            content
            |> inLayout state dispatch title docLink state.Page
        ]
    ]