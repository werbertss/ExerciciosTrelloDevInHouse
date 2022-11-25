using System;
namespace DecimoExercicioTrello;

public class Funcionario
{
    public string Nome { get; set; }
    public string Id { get; set; }

    public Funcionario(string nome, string id)
    {
        Nome = nome;
        Id = id;
    }
}