module GittyGUI.Pages.TestPage.Page

open System
open Feliz
open Elmish

type Model = int

type Msg = HomePageClickMeWasClicked

let init (): Model * Cmd<Msg> =
    0,
    Cmd.none

let update (msg: Msg) (model: Model): Model * Cmd<Msg> =
    match msg with
    | HomePageClickMeWasClicked -> 1 + model, Cmd.none

let view (model: Model) (dispatch: Msg -> unit): ReactElement =
    Html.div [ prop.text "TestPage" ]

let subscribe (model: Model) : (string list * ((Msg -> unit) -> IDisposable)) list = []
