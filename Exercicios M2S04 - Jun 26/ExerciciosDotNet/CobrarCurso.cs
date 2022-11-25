namespace ExercicioNonoTrello;

 public class CobrarCurso
{
    private int ValorCurso {get; set;}
    private int ValorMulta {get; set;}
    private int ValorDesconto {get; set;}
    public int Resultado {get; set;}

    public double MetodoSemDesconto(int Resultado)
    {
        return Resultado = ValorCurso + ValorMulta;
    }

    public double MetodoComDesconto(int Resultado)
    {
        return Resultado = ValorCurso - ValorDesconto;
    }


    public void Mensagem()
    {
        System.Console.WriteLine(@"Para saber quantos liquido a pagar, digite:
        ");

        System.Console.WriteLine("Digite o valor do curso:");
        ValorCurso = Convert.ToInt32(Console.ReadLine()); 

        System.Console.WriteLine("Digite o valor da multa:");
        ValorMulta = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite o valor do desconto:");
        ValorDesconto = Convert.ToInt32(Console.ReadLine());

        if(this.ValorMulta >0)
        {
            System.Console.WriteLine("Valor a pagar é: "+ MetodoSemDesconto(Resultado));
        }
        else if(this.ValorMulta == 0)
        {
           System.Console.WriteLine("Valor a pagar é: "+ MetodoComDesconto(Resultado));
        }

    }
}