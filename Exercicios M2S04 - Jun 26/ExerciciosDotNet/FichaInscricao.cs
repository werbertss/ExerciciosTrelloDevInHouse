namespace ExercicioNonoTrello;

public class FichaInscricao
{
public string Nome {get; set;}
public int Idade {get; set;}
public string Curso {get; set;}
public string Escolaridade {get; set;}
public DateTime DatadeNascimento {get; set;}
public int ValorCurso {get; set;}
public int ValordeDesconto {get; set;}
public int ValorMulta {get; set;}

    public FichaInscricao(string nome, string curso, string escolaridade, DateTime dataDeNascimento,
    int valorCurso, int valordeDesconto, int valorMulta)
    {
        Nome = nome;
        Curso = curso;
        Escolaridade = escolaridade;
        DatadeNascimento = dataDeNascimento;
        ValorCurso = valorCurso;
        ValordeDesconto = valordeDesconto;
        ValorMulta = valorMulta;

        Idade = CalcularIdade();
    }
    private int CalcularIdade()
    {
     return DateTime.Now.Year - DatadeNascimento.Year;  
    }
    
}