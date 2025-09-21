namespace PasswordValidator;

public class PasswordValidator
{
    public bool IsStrongPassword(string senha)
    {
        if (string.IsNullOrEmpty(senha))
        {
            return false;
        }

        if (senha.All(char.IsDigit))
        {
            return false;
        }

        return !string.IsNullOrEmpty(senha) && TemTamanhoMinimo(senha) && TemMaiuscula(senha);
    }
    private bool TemTamanhoMinimo(string senha) => senha.Length >= 8;

    private bool TemMaiuscula(string senha)
    {
        return senha.Any(char.IsUpper);
    }
}