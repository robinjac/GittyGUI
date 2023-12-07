module GittyGUI.Shared

open System
open System.Collections.Generic
open Elmish
open Feliz

type Model = unit

type Msg = | NoOp

type SubscriptionId = | SubscriptionId of Guid

module SubscriptionId =
    let asString (SubscriptionId x) = x.ToString ()

let private subscriptions = Dictionary<SubscriptionId, Msg -> unit> ()

module Cmd =
    // Always use Cmd.ofSharedMsg instead of Cmd.ofMsg in this file.
    // Cmd.ofMsg WON'T send messages to child pages.
    let ofSharedMsg msg =
        for subscription in subscriptions do
            subscription.Value msg

        Cmd.ofMsg msg

let init () = (), Cmd.none

let update msg model =
    match msg with
    | NoOp -> model, Cmd.none

let subscribeShared (f: ('msg -> unit) -> (Msg -> unit)) : string list * (('msg -> unit) -> IDisposable) =
    let subscriptionId = SubscriptionId (Guid.NewGuid ())

    [
        $"Shared_%s{SubscriptionId.asString subscriptionId}"
    ],
    (fun (dispatch: 'msg -> unit) ->
        subscriptions.Add (subscriptionId, f dispatch)

        React.createDisposable (fun () ->
            subscriptions.Remove (subscriptionId)
            |> ignore<bool>))
