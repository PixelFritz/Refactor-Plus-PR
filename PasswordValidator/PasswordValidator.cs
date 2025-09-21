namespace PasswordValidator;

public class PasswordValidator
{
    public bool IsStrongPassword(string senha)
    {
        return !string.IsNullOrEmpty(senha) && TemTamanhoMinimo(senha);
    }
    private bool TemTamanhoMinimo(string senha) => senha.Length >= 8;
}