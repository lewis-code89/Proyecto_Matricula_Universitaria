using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e = new Estudiante();
            Console.Write("Código: ");
            e.Codigo = Console.ReadLine();
            Console.Write("Nombre: ");
            e.Nombre = Console.ReadLine();
            Console.Write("Carrera: ");
            e.Carrera = Console.ReadLine();
            Console.Write("Ciclo (1-10): ");
            e.Ciclo = int.Parse(Console.ReadLine());
            Console.Write("Promedio (0-20): ");
            e.Promedio = double.Parse(Console.ReadLine());
            List<Curso> cursos = new List<Curso>();
            Console.Write("Cantidad de cursos (1-7): ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Curso c = new Curso();
                Console.WriteLine("\nCurso " + (i + 1));
                Console.Write("Nombre: ");
                c.Nombre = Console.ReadLine();
                Console.Write("Créditos: ");
                c.Creditos = int.Parse(Console.ReadLine());
                cursos.Add(c);
            }
            Matricula m = new Matricula();
            int totalCreditos = m.CalcularCreditos(cursos);
            string tipo = m.TipoMatricula(totalCreditos);
            if (tipo == "ERROR")
            {
                Console.WriteLine("\nError:");
                Console.WriteLine("No puede matricularse con más de 22 créditos.");
            }
            else
            {
                double porcentaje = m.CalcularDescuento(e.Promedio);
                double subtotal = m.CalcularSubtotal(totalCreditos);
                double descuento = m.CalcularMontoDescuento(subtotal,porcentaje);
                double total = m.CalcularTotal(subtotal,descuento);
                Console.WriteLine("\n===== REPORTE =====");
                Console.WriteLine("Código: " + e.Codigo);
                Console.WriteLine("Nombre: " + e.Nombre);
                Console.WriteLine("Carrera: " + e.Carrera);
                Console.WriteLine("Ciclo: " + e.Ciclo);
                Console.WriteLine("Promedio: " + e.Promedio);
                Console.WriteLine("\nCursos:");
                foreach (Curso c in cursos)
                {
                    Console.WriteLine(c.Nombre + " - " +c.Creditos + " créditos");
                }
                Console.WriteLine("\nTotal créditos: " + totalCreditos);
                Console.WriteLine("Tipo: " + tipo);
                Console.WriteLine("Subtotal: S/ " + subtotal);
                Console.WriteLine("Descuento: S/ " + descuento);
                Console.WriteLine("Total a pagar: S/ " + total);
            }

            Console.ReadKey();
        }
    }
}
