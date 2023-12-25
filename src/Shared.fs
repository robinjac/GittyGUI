module TestingElmishLand.Shared

open System
open System.Collections.Generic
open Elmish
open Feliz

type SharedModel = unit

type SharedMsg = | NoOp

let init (): SharedModel * Command<'msg, SharedMsg> =
    (), Command.none

let update (msg: SharedMsg) (model: SharedModel): SharedModel * Command<'msg, SharedMsg> =
    match msg with
    | NoOp -> model, Command.none
