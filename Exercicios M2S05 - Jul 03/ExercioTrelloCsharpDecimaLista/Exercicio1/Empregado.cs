using System;
namespace DecimoExercicioTrello;
public class Empregado
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Empregado(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
    
    public void Trabalhar()
    {
        System.Console.WriteLine("Trabalhando!");
    }

    public void IrEmbora()
    {
        System.Console.WriteLine("Indo embora!");
    }

    public void TirarFolga()
    {
        System.Console.WriteLine("De folga!");
    }
}