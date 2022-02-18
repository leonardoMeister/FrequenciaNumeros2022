using System;
using System.Collections.Generic;

namespace FrequenciaNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de numeros à coletar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            List<int> lista = new List<int>();
            List<int> listaContador = new List<int>();

            lista.Add(Convert.ToInt32(Console.ReadLine()));
            listaContador.Add(1);

            for (int x = 0; x < quantidade - 1; x++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                bool deveAdicionar = true;
                for (int i =0; i<lista.Count; i++)
                {

                    if (valor == lista[i])
                    { 
                        listaContador[i]++;
                        deveAdicionar = false;
                        break;  
                    }
                }
                if (deveAdicionar)
                {
                    lista.Add(valor);
                    listaContador.Add(1);
                }
            }
            Console.WriteLine("\n\n");
            for (int i =0; i<lista.Count; i++)
            {
                Console.WriteLine($"{lista[i]} aparece {listaContador[i]} vez(es)");
            }


        }
    }
}
