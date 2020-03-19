# pet-store
Pet Store API client and sample console application.

Many features that would normally be included in production code have been left out to keep this sample simple (e.g. Separation of projects, NuGet deployment, logging, configuration.)

Comments have been included in the code to explain some of the choices, and a few TODO's indicating where the sample could be expanded.

## Getting started
* Run the `Sample` console application to execute the `findByStatus` method on the Pet Store API via the `PetClient` service.
* The `PetStoreSample` service will output available pets to the console, grouped by `Category` and sorted descending by pet `Name`.


## Prerequisites
* Visual Studio 2019
* .NET Core 3.1
* C#

## Running the tests
Execute tests from within `Visual Studio` or via any of the available NUnit test runners.

Only one test currently exists which will execute `PetClient.findByStatus` to ensure that it can deserialize and return a result.
