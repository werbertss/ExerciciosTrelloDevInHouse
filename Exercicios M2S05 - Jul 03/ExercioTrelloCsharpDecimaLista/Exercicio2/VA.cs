using System;
namespace DecimoExercicioTrello;

public class VA: Cartao
{
    public VA(string bandeira, double saldo, double valorTaxa): base(bandeira, saldo, valorTaxa)
    {
    }

    override public double VerificarValorTaxaCartao(double saldo)
    {
        return saldo * 0.05;
    }
}