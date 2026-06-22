using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Matricula
    {
        public int CalcularCreditos(List<Curso> cursos)
        {
            int total = 0;
            foreach (Curso c in cursos)
            {
                total += c.Creditos;
            }
            return total;
        }
        public string TipoMatricula(int total)
        {
            if (total < 12)
            {
                return "Matrícula de tiempo parcial";
            }
            else if (total <= 22)
            {
                return "Matrícula regular";
            }
            else
            {
                return "ERROR";
            }
        }
        public double CalcularDescuento(double promedio)
        {
            if (promedio >= 18)
            {
                return 0.20;
            }
            else if (promedio >= 16)
            {
                return 0.10;
            }
            else
            {
                return 0;
            }
        }
        public double CalcularSubtotal(int creditos)
        {
            return creditos * 85;
        }
        public double CalcularMontoDescuento(double subtotal, double descuento)
        {
            return subtotal * descuento;
        }
        public double CalcularTotal(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
