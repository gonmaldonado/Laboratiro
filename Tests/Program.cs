using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMO
            //Console.WriteLine("Escribe un numero");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Primo(number));
            //Console.WriteLine("Escribe un texto");
            //REPETICION DE PALABRAS EN TEXTO
            //string text = Console.ReadLine();
            //Console.WriteLine(Repeticion(text));
            //Console.ReadKey();
            // TEXTO REVERSO
            Console.WriteLine("Escribe un texto");
            string text = Console.ReadLine();
            Console.WriteLine(Revertir(text));
            Console.ReadKey();
        }

        public static bool Primo(int numero)
        {
            for(int i=2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
        public static string Repeticion(string texto) 
        {
            string[] palabras = texto.Split(' ');
            int[] repeticiones = new int[palabras.Length];

            for (int i = 0; i < palabras.Length; i++)
            {
                for (int b = 0; b < palabras.Length; b++)
                {
                    if (palabras[i] == palabras[b])
                    {
                        repeticiones[i] = repeticiones[i]+ 1;
                    }
                }
                
            }
            int mayor = repeticiones.Max();
            int index = Array.IndexOf(repeticiones, mayor);
            return palabras[index] + "-->" + mayor.ToString() + " " + "repeticiones.";
        }
        public static string Revertir(string texto)
        {
            char[] charArray = texto.ToCharArray();
            string reverso = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverso += charArray[i];
            }
            return reverso;
        }

    }
}
