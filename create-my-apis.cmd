dotnet new ptml-micro-ddd --model-name SomeModel --name HealthChecks.ExampleCrud.SomeModelService --base-namespace HealthChecks.ExampleCrud --force

dotnet sln ./HealthChecks.ExampleCrud.sln add ./HealthChecks.ExampleCrud.SomeModelService/HealthChecks.ExampleCrud.SomeModelService.csproj

dotnet add ./Tests/HealthChecks.ExampleCrud.Tests/HealthChecks.ExampleCrud.Tests.csproj reference ./HealthChecks.ExampleCrud.SomeModelService/HealthChecks.ExampleCrud.SomeModelService.csproj