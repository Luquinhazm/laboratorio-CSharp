using Laboratorio.ClassesDeExemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Fundamentos;

internal class UpCastingEDownCasting
{
    public static void Executar()
    {
        

        // Upcasting pode se feita implicitamente de uma classe derivada para uma classe Base,
        // pois tudo que tem na classe derivada que não será utilizada a partir do resultado do Upcasting simplesmente deixará de ter acesso

        Vendedor vendedor1 = new Vendedor("ana", 27, 100);
        //Pessoa p = vendedor1; // Upcasting implícito 
        vendedor1.Apresentacao() ;

        // DownCasting é necessária que a variavel que sofrerá o downcasting necessita ter uma referência a classe derivada

        Pessoa pessoa1 = new Vendedor("lucas", 21, 101);
        //Pessoa pessoa2 = new Pessoa("ana", 27);

        //Vendedor v1 = pessoa1 as Vendedor;
        //Console.WriteLine(pessoa1.GetType()); // downcasting com o operador as. funciona pois a pessoa1 é Vendedor por debaixo dos panos 
        //v1.Apresentacao();

        //Vendedor v2 = pessoa2 as Vendedor;
        //Console.WriteLine(pessoa2.GetType()); // downcasting com o operador as. não funciona pois pessoa2 é do tipo Pessoa 
        
        // Posso utilizar o operador is para verificar o tipo antes de fazer o downcasting

        //if(pessoa2 is Vendedor)
        //{
        //    Vendedor v3 = pessoa2 as Vendedor;
        //    v3.Apresentacao();
        //}
        //else
        //{
        //    Console.WriteLine("Não é possivel realizar o Downcasting");
        //}
    }
}
