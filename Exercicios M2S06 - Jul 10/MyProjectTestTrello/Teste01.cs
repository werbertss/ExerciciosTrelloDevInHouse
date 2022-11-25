using System;
using Xunit;
namespace MyProjectTestTrello;

public class Teste01
{
 
 [Fact]
    public void MetodoVerifica()
    {
        var usuario01 = new User("Verdadeiro");

        var expected = true;

        var resultado01 = usuario01.SeVerdadeiro();

        Assert.Equal(expected, resultado01);
    }   
    
}