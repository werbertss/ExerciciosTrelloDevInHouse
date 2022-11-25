namespace ExercicioNonoTrello;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite a data do seu nascimento: ");
        var dataDeNascimento = Convert.ToDateTime(Console.ReadLine()); 
        

        FichaInscricao fichaInscricao = new FichaInscricao("Webert", "DevInHouse", "Técnico",
        dataDeNascimento, 370, 15, 5);

        System.Console.WriteLine(fichaInscricao.Idade);

        if(fichaInscricao.ValordeDesconto == 0)
        {
            System.Console.WriteLine("Primeiro If");
            FormatacaoTexto.VerificarTexto("Webert", "DEVinHOUSE", 370);
            System.Console.WriteLine("");
            CobrarCurso a = new CobrarCurso();
            a.Mensagem();
        }

        else if(fichaInscricao.ValordeDesconto > 0 && fichaInscricao.Idade < 18)
        {
            System.Console.WriteLine("Terceiro If");
            FormatacaoTexto.VerificarTexto("Webert", "DEVinHOUSE", 370, 60, 17);
            System.Console.WriteLine("");
            CobrarCurso a = new CobrarCurso();
            a.Mensagem();
        }

        else if(fichaInscricao.ValordeDesconto > 0)
        {
            System.Console.WriteLine("Segundo If");
            FormatacaoTexto.VerificarTexto("Webert", "DEVinHOUSE", 370, 60);
            System.Console.WriteLine("");
            CobrarCurso a = new CobrarCurso();
            a.Mensagem();
        }

 
        }

}