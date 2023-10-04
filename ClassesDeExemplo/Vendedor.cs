using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.ClassesDeExemplo;

public class Vendedor : Pessoa
{
    public Vendedor(string nome, int idade, int numeroDeVenda) : base(nome, idade)
    {
        NumeroDeVenda = numeroDeVenda;
    }
    public int NumeroDeVenda { get; set; }
    public void Apresentacao()
    {
        Console.WriteLine($"Olá sou {Nome} e tenho o numero {NumeroDeVenda}");
    }
}
