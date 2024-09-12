using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio05
{
    //5. Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.
    class Program
    {
        static void Main(string[] args)
        {


            string[] listapalabras = new string[10];
            listapalabras[0] = "oveja";
            listapalabras[1] = "cabra";
            listapalabras[2] = "computadora";
            listapalabras[3] = "argentina";
            listapalabras[4] = "pito";
            listapalabras[5] = "helado";
            listapalabras[6] = "comida";
            listapalabras[7] = "aire";
            listapalabras[8] = "oxigeno";
            listapalabras[9] = "roblox";

            Random PalabraRandom = new Random();

            var palabra = PalabraRandom.Next(0, 9);

            string palabraoculta = listapalabras[palabra];
            
            char[] loqueadivinaste = new char[palabraoculta.Length];
            
            Console.Write("Adivina :D ");

            for (int p = 0; p < palabraoculta.Length; p++)
                loqueadivinaste[p] = '*';

            while (true)
            {
                char palabratuya = char.Parse(Console.ReadLine());
                for (int j = 0; j < palabraoculta.Length; j++)
                {
                    if (palabratuya == palabraoculta[j])
                        loqueadivinaste[j] = palabratuya;
                }
                Console.WriteLine(loqueadivinaste);
            }
        }
    }
}