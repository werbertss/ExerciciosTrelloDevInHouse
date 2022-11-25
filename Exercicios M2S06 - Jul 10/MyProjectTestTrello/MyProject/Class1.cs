namespace MyProjectTestTrello;
public class Class1
{
}

public class User
{
    public User(string nomeString)
    {
        NomeString = nomeString;
    }

    public string NomeString { get; set; }

    private string Nome = "Verdadeiro";
    public bool SeVerdadeiro()
    {
        if(Nome == NomeString)
        {
            return true;
        }
        else
        {
             return false;
        }
    }
}
