namespace TimeTracker.Api.Test.Times

open System
open Microsoft.AspNetCore.Mvc.Testing

open LambdaTale
open Faqt

open TimeTracker.Api.Api

module TimesSpec =

  type TimeEntry = {
    id: string
    userId: string
    start: uint64
    ``end``: uint64 option
    description: string
  }

  type TestApiFactory() =
    inherit WebApplicationFactory<Startup>()

  [<Scenario>]
  let ``Creating a new time entry`` () =
    
    let mutable client = None
    let knownUserId = "a known user"
    let unknownEntryId = "an unknown entry"

    let newEntry: TimeEntry = {
      id = unknownEntryId
      userId = knownUserId
      start = uint64 ((Random()).NextInt64())
      ``end`` = None
      description = "Some description"
    }
        
    "Given a running api".x(fun () -> 
      let factory = new TestApiFactory()
      let asyncClient = Some (factory.CreateClient())
      client <- asyncClient
    ) |> ignore
    
    "And a known user".x(fun () ->
      raise (System.NotImplementedException())
    ) |> ignore

    "When I create a new time entry".x(fun () ->
      raise (System.NotImplementedException())
    ) |> ignore

    "Then the time entry can be seen in the list of entries".x(fun () ->
      raise (System.NotImplementedException())
    ) |> ignore