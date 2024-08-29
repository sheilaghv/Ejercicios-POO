using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    //3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario 
    //    debe adivinar un número generado aleatoriamente por el programa.
    public class numeritomagico
    {
        private Random rng;
        private int numeroadivinar;
        public numeritomagico()
        {
            rng = new Random();
            numeroadivinar = rng.Next(1, 5);

        }


        public void Adivino()
        {
            int inputusuario;
            bool correcto = false;

            while (!correcto)
            {
                Console.WriteLine("Adivina un numero entre el 1 y el 4");
                string input = Console.ReadLine();

                inputusuario = Convert.ToInt32(input);

                if (inputusuario == numeroadivinar)
                {
                    Console.WriteLine("Le pegaste :D");
                    correcto = true;


                }
                else
                {
                    Console.WriteLine("No le pegaste :C");

                }

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                numeritomagico jueguito = new numeritomagico();

                jueguito.Adivino();

                Console.ReadKey();
            }
        }
    }
}
