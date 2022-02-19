# xUnit Tests in Dotnet

## Execute tests in parallel

By default, all the tests run in parallel.

But you may need to configure them to run in stack. Apply the following 👇

## Execute tests in stack

1. Create a new class with name CollectionBehaviourOverride
2. Delete all it's content 
3. Put the following code inside it

```csharp
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
```

## Tests coverage

Search for the `Tests Coverage` option in the IDE and run it.

This option tells how much of your application is covered by tests.
In the perfect scenario, you'll have 100% of coverage.

💡 You can use this percentage in `CI` / `CD` pipelines.