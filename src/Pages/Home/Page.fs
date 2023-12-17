module GittyGUI.Pages.Home.Page

open System
open Feliz
open Elmish

type Model = unit

type Msg = 
    | ClickMeWasClicked

let init (): Model * Cmd<Msg> =
    (),
    Cmd.none

let update (msg: Msg) (model: Model): Model * Cmd<Msg> =
    match msg with
    | ClickMeWasClicked -> model, Cmd.none

let view (model: Model) (dispatch: Msg -> unit): ReactElement =
    Html.div [
        prop.style [ style.display.flex ; style.flexDirection.column ]
        prop.children [
            Html.div [ prop.text "Home" ]
            Html.button [ prop.text "click me" ; prop.onClick (fun _ -> dispatch ClickMeWasClicked) ]
        ]
    ]
    

let subscribe (model: Model) : (string list * ((Msg -> unit) -> IDisposable)) list = []
