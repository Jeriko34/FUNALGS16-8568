using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace veterinaria
{
    internal class Boletas
    {
        public int Codigo { get; set; }
        public Mascota Mascota1 { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public double Total { get; set; }
        public static void Crear(Boletas[] boleta, ref int indice)
        {
            Console.Write("Ingrese el codigo de boleta: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre de la mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el primer tipo de servicio: ");
            string servicio1 = Console.ReadLine();
            Console.Write("Ingrese el segundo tipo de servicio: ");
            string servicio2 = Console.ReadLine();
            Console.Write("Ingrese el total de todo: ");
            double total = double.Parse(Console.ReadLine());
        }
        public static void Listar(Boletas[] boleta, int cantidadBoletas)
        {

        }
    }
}
