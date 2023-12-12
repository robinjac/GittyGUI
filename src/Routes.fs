//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Elmish Land (v1.0.0-alpha.78).
// Here are the available commands:
// 
// dotnet elmish-land init ...... create a new project in the current directory
// dotnet elmish-land upgrade ....... upgrade project to the latest elmish-land
// dotnet elmish-land server ........................... run a local dev server
// dotnet elmish-land build ..................... build your app for production
// dotnet elmish-land add page <url> ........................... add a new page
// dotnet elmish-land add layout <name> ...................... add a new layout
// dotnet elmish-land routes ...................... list all routes in your app
// 
// Want to learn more? Visit https://elmish.land
// 
// This file will be overwritten when re-executing
// 'dotnet elmish-land server' or 'dotnet elmish-land build'.
// </auto-generated>
//------------------------------------------------------------------------------
module GittyGUI.Routes

open Feliz.Router

[<RequireQualifiedAccess>]
type Route =
    | Home
    | NotFound

module Route =
    let asUrl =
        function
        | Route.Home  -> $"#/"
        | Route.NotFound -> "notFound"

    let parse (xs: string list) =
        match xs |> List.map (fun x -> x.ToLowerInvariant ()) with
        | []
        | [] -> Route.Home 
        | other ->
            printfn "Route not found: '%A'" other
            Route.NotFound
