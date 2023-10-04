namespace Laboratorio.ClassesDeExemplo;

public class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Pessoa pessoa &&
               Nome == pessoa.Nome &&
               Idade == pessoa.Idade;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Idade);
    }
}
