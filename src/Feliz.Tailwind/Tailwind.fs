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
