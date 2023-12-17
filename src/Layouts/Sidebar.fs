module GittyGUI.Layouts.Sidebar

open System
open Feliz
open Elmish

type Model = {
    Value: int
}

type Msg = | NoOp  

let init (): Model * Cmd<Msg> =
    { Value = 0 },
    Cmd.none

let update (msg: Msg) (model: Model): Model * Cmd<Msg> =
    match msg with
    | NoOp -> model, Cmd.none

let view (model: Model) (dispatch: Msg -> unit) (pages: ReactElement list): ReactElement =
    Html.div [
        Html.div [ Html.span [ prop.text "Sidebar"] ]
        yield! pages
    ]

let subscribe (model: Model) : (string list * ((Msg -> unit) -> IDisposable)) list = []