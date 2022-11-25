using System;
namespace DecimoExercicioTrello;

public class VR: Cartao
{

    public VR(string bandeira, double saldo, double valorTaxa): base(bandeira, saldo, valorTaxa)
    {
    }

    override public double VerificarValorTaxaCartao(double saldo)
    {
        return saldo * 0.04;
    }
    
}