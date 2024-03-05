namespace TimeTracker.Api.Times
open Microsoft.AspNetCore.Mvc

module Times =
  [<ApiController>]
  [<Route("[controller]")>]
  type TimesController() =
    inherit ControllerBase()

    [<HttpPost>]
    member this.Post() =
      raise (System.NotImplementedException())
      |> ignore