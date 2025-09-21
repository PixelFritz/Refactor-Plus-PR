namespace PasswordValidator;

public class PasswordValidator
{
    public bool IsStrongPassword(string? senha)
    {
        return !string.IsNullOrEmpty(senha)
            && !senha.All(char.IsDigit)
            && TemTamanhoMinimo(senha)
            && TemMaiuscula(senha);
    }
    private bool TemTamanhoMinimo(string senha) => senha.Length >= 8;

    private bool TemMaiuscula(string senha) => senha.Any(char.IsUpper);
}