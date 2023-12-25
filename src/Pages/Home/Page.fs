module TestingElmishLand.Pages.Home.Page

open System
open Feliz
open Elmish
open TestingElmishLand
open TestingElmishLand.Shared

type Model = unit

type Msg = | NoOp

let init (shared: SharedModel) (): Model * Command<Msg, SharedMsg> =
    (),
    Command.none

let update (shared: SharedModel) (msg: Msg) (model: Model): Model * Command<Msg, SharedMsg> =
    match msg with
    | NoOp -> model, Command.none

let view (shared: SharedModel) (model: Model) (dispatch: Msg -> unit): ReactElement =
    Html.text "Home"

let subscribe (model: Model) : (string list * ((Msg -> unit) -> IDisposable)) list = []
