using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program

{
    public static void Main(string[] args)
    {

        int numeroAnterior = 0;
        int numeroAtual = 1;
        int novoNumero;
        int fibonacci;


        for (int i = 0; i < 100; i++)
        {
            fibonacci = numeroAnterior + numeroAtual;
            Console.WriteLine(fibonacci);
            numeroAnterior = numeroAtual;
            numeroAtual = fibonacci;
            Console.ReadKey();
        }



    }
}
    
