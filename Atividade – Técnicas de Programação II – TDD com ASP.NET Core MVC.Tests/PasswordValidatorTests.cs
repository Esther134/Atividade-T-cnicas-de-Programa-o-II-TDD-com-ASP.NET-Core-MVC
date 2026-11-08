using Atividade___Técnicas_de_Programação_II___TDD_com_ASP.NET_Core_MVC.Services;
using NUnit.Framework;

namespace Atividade___Técnicas_de_Programação_II___TDD_com_ASP.NET_Core_MVC.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void IsValid_ReturnsTrue_WhenPasswordMeetsAllRequirements()
    {
        Assert.That(PasswordValidator.IsValid("Senha123"), Is.True);
    }

    [Test]
    public void IsValid_ReturnsFalse_WhenPasswordHasFewerThanEightCharacters()
    {
        Assert.That(PasswordValidator.IsValid("Senha12"), Is.False);
    }

    [Test]
    public void IsValid_ReturnsFalse_WhenPasswordHasNoUppercaseLetter()
    {
        Assert.That(PasswordValidator.IsValid("senha123"), Is.False);
    }

    [Test]
    public void IsValid_ReturnsFalse_WhenPasswordHasNoNumber()
    {
        Assert.That(PasswordValidator.IsValid("Senhaabc"), Is.False);
    }

    [Test]
    public void IsValid_ReturnsFalse_WhenPasswordIsNull()
    {
        Assert.That(PasswordValidator.IsValid(null), Is.False);
    }

    [Test]
    public void IsValid_ReturnsFalse_WhenPasswordIsEmpty()
    {
        Assert.That(PasswordValidator.IsValid(string.Empty), Is.False);
    }
}
