```csharp
using MyDotNetLib;
using Xunit;

namespace MyDotNetApp.Tests;

public class MathServiceTests
{
    private readonly MathService _mathService = new();

    [Fact]
    public void Add_ValidInput_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5, b = 3;
        int expected = 8;

        // Act
        int result = _mathService.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_NegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -2, b = -3;
        int expected = -5;

        // Act
        int result = _mathService.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
```