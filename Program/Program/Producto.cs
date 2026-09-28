using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Producto: {Nombre} | Precio: {Precio} €");
        }
    }
}
