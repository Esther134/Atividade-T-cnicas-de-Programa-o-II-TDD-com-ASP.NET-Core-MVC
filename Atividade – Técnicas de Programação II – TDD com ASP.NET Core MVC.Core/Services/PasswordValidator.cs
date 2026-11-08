namespace Atividade___Técnicas_de_Programação_II___TDD_com_ASP.NET_Core_MVC.Services;

public static class PasswordValidator
{
    public static bool IsValid(string? password)
    {
        return password is not null
            && password.Length >= 8
            && password.Any(char.IsUpper)
            && password.Any(char.IsDigit);
    }
}
