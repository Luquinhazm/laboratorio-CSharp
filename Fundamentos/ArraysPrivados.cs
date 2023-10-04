using Laboratorio.ClassesDeExemplo;

namespace Laboratorio.Fundamentos;
public class ArraysPrivados
{
    private List<Filme> filmes = new();

    public void Adicionar(Filme filme) {
        filmes.Add(filme);
    }

  
    public List<Filme> Ler()
    {
        return filmes;
        //foreach (var filme in filmes)
        //{
        //    Console.WriteLine(filme.Titulo);
        //}
    }

}

public class ArraysPrivadosTeste
{
    public static void Executar()
    {
        var avatar = new Filme();
        avatar.Titulo = "avatar";
        avatar.Genero = "ação";
        avatar.Duracao = 120;
        
        var filmes = new ArraysPrivados();
        filmes.Adicionar(avatar);
        filmes.Ler();
        
    }
}
