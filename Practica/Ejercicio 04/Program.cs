using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_04
{
    
    class Lista
    {
        private int Numero { get; set; }

        public Lista(int numero)
        {
            Numero = numero;
        }

        public void GenerarPrimas()
        {
            Console.WriteLine($"La lista de números primos hasta {Numero} es la siguiente:");
            for (int i = 2; i <= Numero; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        

        private bool EsPrimo(int numero)
        {

            if (numero < 2) 
            {
             return false;
            }
            int limite = (int)Math.Sqrt(numero);
            for (int i = 2; i <= limite; i++)
            {
                if (numero % i == 0)
                {
                    return false;

                }

            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Lista lista = new Lista(numero);
            lista.GenerarPrimas();

            Console.ReadKey();
        }
    }
}
