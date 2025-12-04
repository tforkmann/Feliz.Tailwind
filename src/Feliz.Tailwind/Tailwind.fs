namespace Feliz.Tailwind

open Feliz
open Fable.Core

module Helpers =
    let [<Literal>] private ClassName = "className"

    let inline internal getClasses (xs:IReactProperty list) =
        xs
        |> List.choose (unbox<string * obj> >> function
            | (k, v) when k = ClassName -> Some (string v)
            | _ -> None)

    let extractClasses (xs:IReactProperty list) =
        xs
        |> List.rev
        |> List.fold (fun (classes, props) x ->
            match unbox<string * obj> x with
            | (k, v) when k = ClassName -> string v :: classes, props
            | _ -> classes, x :: props) ([], [])

    let combineClasses cn (xs:IReactProperty list) =
        xs
        |> extractClasses
        |> fun (classes, props) -> (cn :: classes |> prop.classes) :: props

    module Elm =
        let inline props buildFn (xs:IReactProperty list) (cn:string) = buildFn (combineClasses cn xs)
        let inline children buildFn (children:seq<ReactElement>) (cn:string) = buildFn [ prop.className cn; prop.children children ]
        let inline elm buildFn (child:ReactElement) (cn:string) = buildFn [ prop.className cn; prop.children [ child ] ]
        let inline string buildFn (value:string) (cn:string) = buildFn [ prop.className cn; prop.text value ]
        let inline int buildFn (value:int) (cn:string) = buildFn [ prop.className cn; prop.text value ]
        let inline float buildFn (value:float) (cn:string) = buildFn [ prop.className cn; prop.text value ]

[<Erase>]
type Tailwind =
    static member inline borderRadius props = Helpers.Elm.props Html.div props "border-radius"
    static member inline borderRadius (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "border-radius"
    static member inline borderRadius elm = Helpers.Elm.elm Html.div elm "border-radius"
    static member inline borderRadius string = Helpers.Elm.string Html.div string "border-radius"
    static member inline borderRadius int = Helpers.Elm.int Html.div int "border-radius"
    static member inline borderRadius float = Helpers.Elm.float Html.div float "border-radius"

    static member inline flex props = Helpers.Elm.props Html.div props "flex"
    static member inline flex (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "flex"
    static member inline flex elm = Helpers.Elm.elm Html.div elm "flex"
    static member inline flex string = Helpers.Elm.string Html.div string "flex"
    static member inline flex int = Helpers.Elm.int Html.div int "flex"
    static member inline flex float = Helpers.Elm.float Html.div float "flex"

    static member inline grid props = Helpers.Elm.props Html.div props "grid"
    static member inline grid (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "grid"
    static member inline grid elm = Helpers.Elm.elm Html.div elm "grid"
    static member inline grid string = Helpers.Elm.string Html.div string "grid"
    static member inline grid int = Helpers.Elm.int Html.div int "grid"
    static member inline grid float = Helpers.Elm.float Html.div float "grid"

    static member inline divCombine props = Helpers.Elm.props Html.div props ""
    static member inline divCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children ""
    static member inline divCombine elm = Helpers.Elm.elm Html.div elm ""
    static member inline divCombine string = Helpers.Elm.string Html.div string ""
    static member inline divCombine int = Helpers.Elm.int Html.div int ""
    static member inline divCombine float = Helpers.Elm.float Html.div float ""

    static member inline spanCombine props = Helpers.Elm.props Html.span props ""
    static member inline spanCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.span children ""
    static member inline spanCombine elm = Helpers.Elm.elm Html.span elm ""
    static member inline spanCombine string = Helpers.Elm.string Html.span string ""
    static member inline spanCombine int = Helpers.Elm.int Html.span int ""
    static member inline spanCombine float = Helpers.Elm.float Html.span float ""

    static member inline pCombine props = Helpers.Elm.props Html.p props ""
    static member inline pCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.p children ""
    static member inline pCombine elm = Helpers.Elm.elm Html.p elm ""
    static member inline pCombine string = Helpers.Elm.string Html.p string ""
    static member inline pCombine int = Helpers.Elm.int Html.p int ""
    static member inline pCombine float = Helpers.Elm.float Html.p float ""

    static member inline h1Combine props = Helpers.Elm.props Html.h1 props ""
    static member inline h1Combine (children: #seq<ReactElement>) = Helpers.Elm.children Html.h1 children ""
    static member inline h1Combine elm = Helpers.Elm.elm Html.h1 elm ""
    static member inline h1Combine string = Helpers.Elm.string Html.h1 string ""

    static member inline h2Combine props = Helpers.Elm.props Html.h2 props ""
    static member inline h2Combine (children: #seq<ReactElement>) = Helpers.Elm.children Html.h2 children ""
    static member inline h2Combine elm = Helpers.Elm.elm Html.h2 elm ""
    static member inline h2Combine string = Helpers.Elm.string Html.h2 string ""

    static member inline h3Combine props = Helpers.Elm.props Html.h3 props ""
    static member inline h3Combine (children: #seq<ReactElement>) = Helpers.Elm.children Html.h3 children ""
    static member inline h3Combine elm = Helpers.Elm.elm Html.h3 elm ""
    static member inline h3Combine string = Helpers.Elm.string Html.h3 string ""

    static member inline buttonCombine props = Helpers.Elm.props Html.button props ""
    static member inline buttonCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.button children ""
    static member inline buttonCombine elm = Helpers.Elm.elm Html.button elm ""
    static member inline buttonCombine string = Helpers.Elm.string Html.button string ""

    static member inline aCombine props = Helpers.Elm.props Html.a props ""
    static member inline aCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.a children ""
    static member inline aCombine elm = Helpers.Elm.elm Html.a elm ""
    static member inline aCombine string = Helpers.Elm.string Html.a string ""

    static member inline liCombine props = Helpers.Elm.props Html.li props ""
    static member inline liCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.li children ""
    static member inline liCombine elm = Helpers.Elm.elm Html.li elm ""
    static member inline liCombine string = Helpers.Elm.string Html.li string ""

    static member inline ulCombine props = Helpers.Elm.props Html.ul props ""
    static member inline ulCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.ul children ""

    static member inline sectionCombine props = Helpers.Elm.props Html.section props ""
    static member inline sectionCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.section children ""

    static member inline articleCombine props = Helpers.Elm.props Html.article props ""
    static member inline articleCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.article children ""

    static member inline headerCombine props = Helpers.Elm.props Html.header props ""
    static member inline headerCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.header children ""

    static member inline footerCombine props = Helpers.Elm.props Html.footer props ""
    static member inline footerCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.footer children ""

    static member inline navCombine props = Helpers.Elm.props Html.nav props ""
    static member inline navCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.nav children ""

    static member inline mainCombine props = Helpers.Elm.props Html.main props ""
    static member inline mainCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.main children ""

    static member inline asideCombine props = Helpers.Elm.props Html.aside props ""
    static member inline asideCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.aside children ""

    static member inline labelCombine props = Helpers.Elm.props Html.label props ""
    static member inline labelCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.label children ""
    static member inline labelCombine string = Helpers.Elm.string Html.label string ""

    static member inline inputCombine props = Helpers.Elm.props Html.input props ""

    static member inline textareaCombine props = Helpers.Elm.props Html.textarea props ""

    static member inline formCombine props = Helpers.Elm.props Html.form props ""
    static member inline formCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.form children ""

    static member inline tableCombine props = Helpers.Elm.props Html.table props ""
    static member inline tableCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.table children ""

    static member inline theadCombine props = Helpers.Elm.props Html.thead props ""
    static member inline theadCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.thead children ""

    static member inline tbodyCombine props = Helpers.Elm.props Html.tbody props ""
    static member inline tbodyCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.tbody children ""

    static member inline trCombine props = Helpers.Elm.props Html.tr props ""
    static member inline trCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.tr children ""

    static member inline thCombine props = Helpers.Elm.props Html.th props ""
    static member inline thCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.th children ""
    static member inline thCombine string = Helpers.Elm.string Html.th string ""

    static member inline tdCombine props = Helpers.Elm.props Html.td props ""
    static member inline tdCombine (children: #seq<ReactElement>) = Helpers.Elm.children Html.td children ""
    static member inline tdCombine string = Helpers.Elm.string Html.td string ""

    static member inline imgCombine props = Helpers.Elm.props Html.img props ""
