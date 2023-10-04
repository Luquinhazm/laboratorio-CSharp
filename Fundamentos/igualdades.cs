using Laboratorio.ClassesDeExemplo;

namespace Laboratorio.Fundamentos;

internal class igualdades
{
    public static void Executar()
    {
        // Operador == 
        int num1 = 10; 
        int num2 = 10;

        var pessoa1 = new Pessoa("lucas", 21);
        var pessoa2 = new Pessoa("lucas", 21);


        Console.WriteLine(num1 == num2); // Para tipos de valor é comparado os conteúdo;
        Console.WriteLine(pessoa1 == pessoa2); // Para tipos de referencia é comparado o local onde a variavel está armazenada;
                                               

        // Método Equals  
        // funciona igual == para tipos de valor. Para tipo de referencia, se implementado, comparar os conteúdos.
        Console.WriteLine(pessoa1.Equals(pessoa2));

        // operador Is 
        Console.WriteLine(pessoa1 is Pessoa); // Compara os tipos...
    }
}
