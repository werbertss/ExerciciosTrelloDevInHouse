using System;
namespace DecimoExercicioTrello;

public class Cartao
{
    public string Bandeira { get; set; }
    public double Saldo { get; set; }
    public double ValorTaxa { get; set; }

    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
        Bandeira = bandeira;
        Saldo = saldo;
        ValorTaxa = valorTaxa;
    }
    virtual public double VerificarValorTaxaCartao(double saldo)
    {
        return saldo * 0;
    }
}