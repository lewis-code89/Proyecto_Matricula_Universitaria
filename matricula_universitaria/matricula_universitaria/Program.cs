using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace matricula_universitaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("SISTEMA DE MATRICULA");
                Console.WriteLine("1.Registrar estudiante \n2.Salir");
                Console.Write("Ingrese su opción: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        funciones.registar_estudiante();
                        break;
                    default:
                        Console.WriteLine("Opción no válida!!! Intende de nuevo...");
                        break;
                }
            } while (x != 2);
            
        }
    }
}
