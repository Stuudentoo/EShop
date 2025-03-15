using EShop.Application;

namespace EShop.Application.Tests;
public class CreditCardServiceTest
{
    [Fact]
    public void ValidateCard_Correct_ReturnTrue()
    {
        // Arrange
        var card = new CreditCardService();
        string cardNumber = "12345678901234567";
        // Act
        var result = card.ValidateCard(cardNumber);

        // Assert
        Assert.True(result);
    }
    [Fact]
    public void ValidateCard_TooShort_ReturnFalse()
    {
        // Arrange
        var card = new CreditCardService();
        string cardNumber = "123456789";
        // Act
        var result = card.ValidateCard(cardNumber);

        // Assert
        Assert.False(result);
    }
    [Fact]
    public void ValidateCard_TooLong_ReturnFalse()
    {
        // Arrange
        var card = new CreditCardService();
        string cardNumber = "1234567890123456789012345";
        // Act
        var result = card.ValidateCard(cardNumber);

        // Assert
        Assert.False(result);
    }
    [Fact]
    public void ValidateCard_WithPauses_ReturnTrue()
    {
        // Arrange
        var card = new CreditCardService();
        string cardNumber = "1234-5678-9012-3456";
        // Act
        var result = card.ValidateCard(cardNumber);

        // Assert
        Assert.True(result);
    }
    [Fact]
    public void ValidateCard_WithSpaces_ReturnTrue()
    {
        // Arrange
        var card = new CreditCardService();
        string cardNumber = "1234 5678 9012 3456";
        // Act
        var result = card.ValidateCard(cardNumber);

        // Assert
        Assert.True(result);
    }
}