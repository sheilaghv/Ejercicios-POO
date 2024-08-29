using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosevaluacion
{
    //1. Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.
    class Numero
    {
        public int[] Numerosingresados = new int[4];
        public Numero(int[] Numerosingresados)
        {

            this.Numerosingresados = Numerosingresados;
        }
        public void IngresarNumeros()
        {
            Console.WriteLine("Ingrese 4 numeros: ");

            for (int i = 0; i < Numerosingresados.Length; i++)
            {
                Numerosingresados[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double CalcularPromedio()
        {

            double suma = Numerosingresados.Sum();
            return suma / Numerosingresados.Length;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numerosIngresados = new int[4];
            Numero num = new Numero(numerosIngresados);

            num.IngresarNumeros();

            double promedio = num.CalcularPromedio();
            Console.WriteLine(promedio);

            Console.ReadKey();
        }
  
    }
}