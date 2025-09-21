using Xunit;
using PasswordValidator;

public class PasswordValidatorTests
{
    // Happy Path
    [Fact]
    public void SenhaValida()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.IsStrongPassword("Abcde*12"));
    }

    // Edge Cases
    [Fact]
    public void SenhaComExatamente8Caracteres_DeveRetornarTrue()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.IsStrongPassword("12345678"));
    }

    [Fact]
    public void SenhaCom7Caracteres_DeveRetornarFalse()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.IsStrongPassword("Abc1234"));
    }

    [Fact]
    public void SenhaVazia_DeveRetornarFalse()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.IsStrongPassword(""));
    }

    [Fact]
    public void SenhaNula_DeveRetornarFalse()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.IsStrongPassword(null));
    }
}