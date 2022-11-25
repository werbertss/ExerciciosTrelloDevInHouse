namespace ExercicioNonoTrello;

public static class FormatacaoTexto
{
    static public string Nome { get; set; }
    static public string Curso { get; set; }
    static public int ValorCurso { get; set; }
    static public int ValorDesconto { get; set; }
    static public int Idade { get; set; }

    
    static public void VerificarTexto(string Nome, string Curso, int ValorCurso)
    {
         System.Console.WriteLine($"O seu nome é {Nome} e o curso é {Curso}, Valor do curso é {ValorCurso}");
    }

    static public void VerificarTexto(string Nome, string Curso, int ValorCurso, int ValorDesconto)
    {
         System.Console.WriteLine($"O seu nome é {Nome} e o curso é {Curso}, Valor do Curso é {ValorCurso}, E o desconto é {ValorDesconto}");
    }

    static public void VerificarTexto(string Nome, string Curso, int ValorCurso, int ValorDesconto, int Idade)
    {
        System.Console.WriteLine($"O seu nome é {Nome} e o curso é {Curso}, Valor do curso {ValorCurso}, Valor do desconto {ValorDesconto}, e sua idade é {Idade}");
    }
   
    }