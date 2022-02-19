# Share tests context across multiple classes

You may need to have the same context shared across multiple classes.

To do that, you need to do the following:

1. Create a class that will contain the definition name. Like `GuidGeneratorDefinition.cs`
2. In all the classes that you need to share the context, include `[Collection("definition_name")]`

For this example, the same `GuidGenerator` instance will be the same.

You can use this functionality to create and improve integration tests with xUnit.