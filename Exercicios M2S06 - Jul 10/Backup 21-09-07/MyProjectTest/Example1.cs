using System;
using Xunit;
namespace MyProjectTest;

public class Example1
{
    //[Fact] aparentemente serve para declarar que será iniciado um teste abaixo
    [Fact]
    public void UsuarioMaiorDEIdade()
    {
        //Criando um Arrange, que é um usuario com nome e idade
        var user = new User("José", 50);
        //Expect o que esperamos que seja
        var expected = true;
        //Act 
        var result = user.MaiorDeIdade();
        //Assert a comparação para ver se é true ou false
        Assert.Equal(expected, result);
    }

    [Fact]
    public void UsuarioMenorDEIdade()
    {
        var user = new User("João", 17);
        var expected = false;
        var result = user.MaiorDeIdade();
        Assert.Equal(expected, result);
    }
}