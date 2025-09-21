using Xunit;
using PasswordValidator;

public class PasswordValidatorTests
{
    // Happy Path - Senha válida (8 ou mais dígitos)
    [Fact]
    public void SenhaValida()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.IsStrongPassword("Abcde*12"));
    }

    // Edge Cases - Igual a 8, menor que 8, vazio e nulo
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

    // Happy Path - Senha Valida (possui letra maiuscula)
    [Fact]
    public void SenhaComLetraMaiuscula_DeveRetornarTrue()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.IsStrongPassword("Abc12345"));
    }

    // Edge Case - senha não possui letra maiuscula
    [Fact]
    public void SenhaSemLetraMaiuscula_DeveRetornarFalse()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.IsStrongPassword("abc12345"));
    }
}