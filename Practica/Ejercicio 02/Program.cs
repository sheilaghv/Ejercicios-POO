using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    //2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.

    class Cajero
    {

        private double Saldo { get; set; }

        public Cajero(double saldo)
        {
            Saldo =saldo ;
        
        }
        public void HacerDepositos() 
        {

            Console.WriteLine("Cantidad a ingresar: ");
            Saldo=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Saldo: {Saldo}");
        }

        public void HacerRetirosyConsultarSaldo() 
        {
            Console.WriteLine("Cantidad a retirar: ");
            double saldoactual;
            saldoactual = Convert.ToInt64(Console.ReadLine());
            
            if(Saldo != 0)
            {

                saldoactual = (Saldo- saldoactual);
                

            }
            Console.WriteLine($"Saldo: {saldoactual}");

        }

        
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            double Saldo = saldo;

            Cajero cajero= new Cajero(Saldo);

            cajero.HacerDepositos();
            cajero.HacerRetirosyConsultarSaldo();
          

            Console.ReadKey();
        }
    }
}
