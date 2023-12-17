module GittyGUI.Pages.Test.Layout

open Feliz
open GittyGUI.Routes

type Msg = | NoOp

let view (route: Route) (child: ReactElement): ReactElement =
    Html.div [
        Html.div [
            prop.text "Pages.Test.Layout"
        ]
        child
    ]