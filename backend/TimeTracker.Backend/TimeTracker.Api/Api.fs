namespace TimeTracker.Api

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

module Api =
  
  type Startup() =

    member _.ConfigureServices(services: IServiceCollection) =
      services.AddControllers() |> ignore

    member _.Configure(app: IApplicationBuilder) =
      app.UseHttpsRedirection() |> ignore
      app.UseAuthorization() |> ignore
      app.UseRouting() |> ignore
      app.UseEndpoints(fun config ->
        config.MapControllers() |> ignore)
      |> ignore

    member _.CreateHostBuilder() =
      Host
        .CreateDefaultBuilder()
        .ConfigureWebHostDefaults(fun webBuilder ->
          webBuilder.UseStartup<Startup>() |> ignore)
  
  let exitCode = 0

  [<EntryPoint>]
  let RunApi args =

    (new Startup())
      .CreateHostBuilder()
      .Build()
      .Run()
    
    exitCode
