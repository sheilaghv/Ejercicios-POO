using System;
using System.Collections.Generic;

namespace Ejercicio06
{
    internal class Program
    {
        public class Tarea
        {
            public string Nombre { get; set; }
            public int Prioridad { get; set; }

            public Tarea(string nombre, int prioridad)
            {
                Nombre = nombre;
                Prioridad = prioridad;
            }

            public override string ToString()
            {
                return $"{Nombre} - Prioridad: {Prioridad}";
            }
        }

        static void Main(string[] args)
        {
            List<Tarea> tareas = new List<Tarea>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la prioridad de la tarea (número entero): ");
                if (int.TryParse(Console.ReadLine(), out int prioridad))
                {
                    tareas.Add(new Tarea(nombre, prioridad));
                }
                else
                {
                    Console.WriteLine("Prioridad no válida, debes ingresar un número entero.");
                }

                Console.WriteLine("¿Deseas agregar otra tarea? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();
                continuar = respuesta == "s";
            }

            // Ordenar las tareas por prioridad usando el algoritmo de ordenación por burbuja
            OrdenarPorPrioridad(tareas);

            // Mostrar la lista de tareas ordenada
            Console.WriteLine("\nLista de tareas ordenada por prioridad:");
            foreach (Tarea tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
            Console.ReadKey();
        }
        static void OrdenarPorPrioridad(List<Tarea> tareas)
        {
            int n = tareas.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tareas[j].Prioridad > tareas[j + 1].Prioridad)
                    {
       
                        Tarea temp = tareas[j];
                        tareas[j] = tareas[j + 1];
                        tareas[j + 1] = temp;
                    }
                }
            }
        }
    }
}
