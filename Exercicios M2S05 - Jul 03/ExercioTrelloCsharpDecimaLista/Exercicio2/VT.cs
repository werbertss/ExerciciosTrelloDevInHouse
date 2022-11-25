using System;
namespace DecimoExercicioTrello;

public class VT: Cartao
{
    public VT(string bandeira, double saldo, double valorTaxa): base(bandeira, saldo, valorTaxa)
    {
    }

    override public double VerificarValorTaxaCartao(double saldo)
    {
        return saldo * 0.06;
    }
}