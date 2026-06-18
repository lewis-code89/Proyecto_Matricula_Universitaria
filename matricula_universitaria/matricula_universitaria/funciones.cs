using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matricula_universitaria
{
    internal class funciones
    {
        public static int x,y, a, b, c, suma = 0;
        public static string tipo;
        public static void registar_cursos()
        {
            Console.Write("Ingrese la cantidad de curso: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0 || x > 7)
            {
                Console.WriteLine("Error! Registro no válido...");
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"Ingrese el nombre del curso #{i+1}: ");
                    arreglos.Curso[i]= Console.ReadLine();
                    Console.Write($"Ingrese la camtidad de créditos del curso #{i+1}: ");
                    arreglos.credito[i] = Convert.ToInt16(Console.ReadLine());
                }
                for(int i = 0;i < x; i++)
                {
                    suma += arreglos.credito[i];
                }
                if (suma < 0 || suma > 22)
                {
                    Console.WriteLine("Superaste el limite de créditos permitidos, registro incorrecto....");
                }
            }
        }
        public static void determinar_tipo_matricula()
        {
            if (suma < 12)
            {
                tipo = "Matrícula de tiempo parcial";
            }
            else if (suma >= 12 && suma <= 22)
            {
                tipo = "Matrícula regular";
            }
            else
            {
                Console.WriteLine("ERROR!!! Matrícula inválida");
            }
        }

        public static void registar_estudiante()
        {
            int i = arreglos.contador;
            Console.Write("Ingrese el código: ");
            arreglos.codigo_estudiante[i]=Console.ReadLine();
            Console.Write("Ingrese el nombre completo: ");
            arreglos.nombre_estudiante[i] = Console.ReadLine();
            Console.Write("Ingrese la carrera: ");
            arreglos.carrera[i] = Console.ReadLine();
            Console.Write("Ingrese el ciclo: ");
            arreglos.ciclo[i] = Console.ReadLine();
            Console.Write("Ingrese el promedio ponderado del ciclo anterior: ");
            arreglos.promedio_anterior[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            registar_cursos();
            determinar_tipo_matricula();

        }

    }
}
