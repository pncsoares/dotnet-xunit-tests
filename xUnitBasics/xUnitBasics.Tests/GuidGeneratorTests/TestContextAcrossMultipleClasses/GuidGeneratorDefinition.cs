using Xunit;

namespace xUnitBasics.Tests.GuidGeneratorTests.TestContextAcrossMultipleClasses;

[CollectionDefinition("GuidGeneratorDefinition")]
public class GuidGeneratorDefinition : ICollectionFixture<GuidGenerator>
{
    
}