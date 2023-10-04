using System.Drawing;

namespace Laboratorio.Algoritmos;

class BinarySearch
{
   public static int Implementacao(List<int> nums, int target)
    {
        var listaASerBuscada = nums;

        int left = 0;
        int right = listaASerBuscada.Count - 1;

        while (left < right)
        {
            int mid = left + (right-left)/2;
            if (listaASerBuscada[mid] == target)
            {
                Console.Write("Alvo achado ele está no index: ");
                return mid ;
            } else if (listaASerBuscada[mid]< target)
            {
                left = mid+1;
            } 
            else right = mid;
        }

        if (listaASerBuscada[left] == target) return left;
        
        return -1;
 
    }
    public static void Executar()
    {
        var lista = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
    
        Console.WriteLine(BinarySearch.Implementacao(lista, 16));
    }
}