namespace PasswordValidator;

public class PasswordValidator
{
    public bool IsStrongPassword(string senha)
    {
        if (string.IsNullOrEmpty(senha))
        {
            return false;
        }

        if (senha.Length < 8)
        {
            return false;
        }

        return TemTamanhoMinimo(senha);
    }
    private bool TemTamanhoMinimo(string senha)
    {
        return senha.Length >= 8;
    }
}