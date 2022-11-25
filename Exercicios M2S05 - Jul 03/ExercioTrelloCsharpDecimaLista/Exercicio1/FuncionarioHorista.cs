using System;
namespace DecimoExercicioTrello;

public class FuncionarioHorista: Empregado
{
    public string CNPJ { get; set; }
    public double Taxa { get; set; }

    public FuncionarioHorista(int id, string nome, string cNPJ, double taxa) : base(id, nome)
    {
        CNPJ = cNPJ;
        Taxa = taxa;
    }

    public void CalcularTaxas()
    {
        System.Console.WriteLine("Calculando taxas!");
    }

    public void EmitirNota()
    {
        System.Console.WriteLine("Emitindo nota!");
    }
}