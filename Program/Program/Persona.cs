using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public int getEdad()
        {
            return Edad;
        }

        public void setEdad(int nuevaEdad)
        {
            this.Edad = nuevaEdad;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años");
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}
