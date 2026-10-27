
using EShop.Application;
using Xunit;

namespace EShop.Application.Tests;

public class CreditCardServiceTests
{
    [Theory]
    [InlineData("4532289052809181", true)]
    [InlineData("4532 2080 2150 4434", true)]
    [InlineData("4024-0071-6540-1778", true)]
    [InlineData("1234567890123", false)]
    [InlineData("453228905280918", false)]
    [InlineData("4532289052809182", false)]
    [InlineData("4532-ABCD-2150-4434", false)]
    [InlineData("", false)]
    [InlineData("   ", false)]
    public void ValidateCard_ReturnsExpectedResult(
        string cardNumber, bool expected)
    {
        // Arrange
        var service = new CreditCardService();

        // Act
        var result = service.ValidateCard(cardNumber);

        // Assert
        Assert.Equal(expected, result);
    }
}
