using System;
using System.Text.RegularExpressions;
namespace DecimoExercicioTrello;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Usando a classe SalarioEmpregado
        System.Console.WriteLine(@" Exercicio 1
        ");
        SalarioEmpregado empregado01 = new SalarioEmpregado(01, "Webert", 03, 6000);
        System.Console.WriteLine($"Funcionario: \nId: {empregado01.Id}, Nome {empregado01.Nome},\nNumero do funcionario {empregado01.CodigoFuncionario}, Valor do salario é {empregado01.ValorSalario}.");
        empregado01.Trabalhar(); //metodo Trabalhar da classe Empregado
        empregado01.IrEmbora(); //metodo IrEmbora da classe Empregado
        empregado01.TirarFolga(); //metodo TirarFolga da classe Empregado

        empregado01.CalcularFolhaPagamento(); // metodo CalcularFolhaPagamento da classe SalarioEmpregado
        

        System.Console.WriteLine(@"
        
        ----------------------------------------------------------------------------------
        
        ");


        //Usando a classe FuncionarioHorista
        FuncionarioHorista trabalhador01 = new FuncionarioHorista (02, "Webert", "0000000/0001", 10);
        System.Console.WriteLine($"Horista: \nId: {trabalhador01.Id}, Nome: {trabalhador01.Nome},\nCNPJ: {trabalhador01.CNPJ}, Taxa: {trabalhador01.Taxa}");

        trabalhador01.Trabalhar(); //metodo Trabalhar da classe Empregado
        trabalhador01.IrEmbora(); //metodo IrEmbora da classe Empregado
        trabalhador01.TirarFolga(); //metodo TirarFolga da classe Empregado

        trabalhador01.CalcularTaxas(); // metodo CalcularTaxas da classe FuncionarioHorista
        trabalhador01.EmitirNota(); // metodo EmitirNota da classe FuncionarioHorista

        System.Console.WriteLine(@"
        ----------------------------------------------------------------------------------
        ");


        System.Console.WriteLine(@" Exercicio 2
        ");

        //Nessa parte também inclui modificações solicitadas pelo Exercicio 04
        System.Console.WriteLine("Modificações do exercicio 04 abaixo:");
        System.Console.WriteLine("Taxa do VR:");
        VR VR01 = new VR("Webert", 200, 0.04);
        System.Console.WriteLine(VR01.VerificarValorTaxaCartao(VR01.Saldo));
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("Tada do VA:");
        VA VA01 = new VA("Webert", 600, 0.05);
        System.Console.WriteLine(VA01.VerificarValorTaxaCartao(VA01.Saldo));
        System.Console.WriteLine("----------------------------------------");

        System.Console.WriteLine("Tada do VT:");
        VT VT01 = new VT("Webert", 250, 0.06);
        System.Console.WriteLine(VT01.VerificarValorTaxaCartao(VT01.Saldo));

        System.Console.WriteLine(@"
        ----------------------------------------------------------------------------------
        ");

        System.Console.WriteLine("Exercicio 03 e outros");
        //Upcast
        System.Console.WriteLine("UpCast");
        Cartao UPVR01 = new VR ("UPVR01", 200, 0.04);
        System.Console.WriteLine($"Resultado UPVR01: {UPVR01.Bandeira}, {UPVR01.Saldo}, {UPVR01.ValorTaxa}");
        Cartao UPVA02 = new VA ("UPVA02", 600, 0.05);
        System.Console.WriteLine($"Resultado UPVA02: {UPVA02.Bandeira}, {UPVA02.Saldo}, {UPVA02.ValorTaxa}");
        Cartao UPVT03 = new VT ("UPVT03", 250, 0.06);
        System.Console.WriteLine($"Resultado UPVT03: {UPVT03.Bandeira}, {UPVT03.Saldo}, {UPVT03.ValorTaxa}");


        //DownCast
        System.Console.WriteLine("DownCast");
        VR DOWNVR01 = (VR)UPVR01;
        System.Console.WriteLine($"Resultado DOWNVR01: {DOWNVR01.Bandeira}, {DOWNVR01.Saldo}, {DOWNVR01.ValorTaxa}");
        VA DOWNVA01 = (VA)UPVA02;
        System.Console.WriteLine($"Resultado DOWNVA01: {DOWNVA01.Bandeira}, {DOWNVA01.Saldo}, {DOWNVA01.ValorTaxa}");
        VT DOWNVT01 = (VT)UPVT03;
        System.Console.WriteLine($"Resultado DOWNVT01: {DOWNVT01.Bandeira}, {DOWNVT01.Saldo}, {DOWNVT01.ValorTaxa}");
    
        System.Console.WriteLine(@"
        ----------------------------------------------------------------------------------
        ");

        System.Console.WriteLine(@"Exercicio 05
        ");

        //Verificação para o id
        Regex regexNumeros = new Regex("^[0-9]+$");

        Funcionario objFuncionario = new Funcionario ("adotnet", "id");

        if(objFuncionario.Nome == "")
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            System.Console.WriteLine("Seu funcionario está preenchido!");
            /* var teste = regexNumeros;
            if(funcionario01.Id == teste)
            {
                System.Console.WriteLine("Corretor");
            }
            else{} */
            try
            {
                ValidacaoNomeFuncionario(objFuncionario);
                ValidacaoIDFuncionario(objFuncionario);
                VerificaObjetoFuncionarioNull(objFuncionario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. Mensagem: {ex.Message}");
            }
            
        }

         static void VerificaObjetoFuncionarioNull(Funcionario objFuncionario)
        {
            if (objFuncionario == null)
            {
                throw new NullReferenceException("\nO objeto Funcionário está " +
                    "nulo. Informe os valores. \n");
            }

            Console.WriteLine(
                $"\n- O nome do funcionário é: {objFuncionario.Nome}\n" +
                $"- O ID é: {objFuncionario.Id}\n");
        }


         static void ValidacaoNomeFuncionario(Funcionario objFuncionario)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(objFuncionario.Nome))
            {
                throw new NomeFuncionarioInvalidoException(objFuncionario.Nome);
            }
        }

         static void ValidacaoIDFuncionario(Funcionario objFuncionario)
        {
            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(objFuncionario.Id))
            {
                throw new IDFuncionarioInvalidoException(objFuncionario.Id);
            }
    
    }
}


}