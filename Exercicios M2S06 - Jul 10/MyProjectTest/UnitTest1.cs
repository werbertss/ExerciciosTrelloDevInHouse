/*
using System;
using Xunit;
namespace MyProjectTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange (Preparar)
        //Act (Agir)
        //Assert(Verificar)
    }

    public void EstruturaAAA()
    {
        //Arrange
        var cpf = "111-111-111-00";

        //Expectativa de que ele seja
        var expected = false;

        //Act
        var resultado = validaCPF(cpf);
        //Assert
        Assert.True(resultado);
        Assert.Equal(expected, resultado);
    }

    // A diferença do teste de 4 passo, que ele limpa o teste no final.
    public void Estrutura4Passos()
    {
        //Setup
        var cpf = "111-111-111-00";

        //Expectativa de que ele seja
        var expected = false;

        //Exercise
        var resultado = validaCPF(cpf);
        //Verify
        Assert.True(resultado);
        Assert.Equal(expected, resultado);
        //Tardown - Destruir/limpar
        cpf = null;
    }
}
*/