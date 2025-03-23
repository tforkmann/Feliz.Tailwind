module Docs.Pages.BorderRadius

open Feliz
open Elmish
open Feliz.UseElmish
open Feliz.DaisyUI
open Feliz.Tailwind
open Feliz.Tailwind.Operators
open Docs.SharedView

let ex1 =
    let example =
        Tailwind.divCombine
            [ Daisy.button.button
                  [ button.outline
                    button.primary
                    button.lg
                    borderRadius.rounded3Xl
                    prop.text "This is rounded3XL" ] ]

    let code =
        """
         Tailwind.divCombine
            [ Daisy.button.button
                  [ button.outline
                    button.primary
                    button.lg
                    borderRadius.rounded3Xl
                    prop.text "This is rounded3XL" ] ]"""

    let title = Html.text "Use of borderRadius is rather straightforward."
    codedView title code example

let ex2 =
    let example =
        Tailwind.borderRadius [ borderRadius.rounded2Xl; prop.text "Rounded 2XL" ]
        |> Html.div

    let code =
        """
        Tailwind.divCombine
            [ Daisy.button.button
                  [ button.outline
                    button.primary
                    button.lg
                    borderRadius.rounded2Xl
                    prop.text "This is rounded2XL" ] ]"""

    let title = Html.none
    codedView title code example

let ex3 =
    let example =
        Tailwind.borderRadius [ borderRadius.rounded3Xl; prop.text "Rounded 3Xl" ]
        |> Html.div

    let code =
        """Tailwind.borderRadius [
    alert.error
    prop.text "OMG, something went wrong!"
]"""

    let title = Html.none
    codedView title code example

let ex4 =
    let example =
        Tailwind.borderRadius
            [ borderRadius.roundedNone
              prop.className "Rounded None"
              prop.children
                  [ Html.i [ prop.className "fas fa-exclamation-triangle mr-2" ]
                    Html.label [ prop.text "Warning with cool icon" ] ] ]
        |> Html.div

    let code =
        """Tailwind.borderRadius [
    borderRadius.warning
    prop.className "justify-start"
    prop.children [
        Html.i [ prop.className "fas fa-exclamation-triangle mr-2" ]
        Html.label [ prop.text "Warning with cool icon" ]
    ]
]"""

    let title = Html.none
    codedView title code example

[<ReactComponent>]
let BorderRadiusView () = React.fragment [ ex1;ex2;ex3;ex4 ]