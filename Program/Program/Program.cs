namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona persona1 = new Persona("Carlos", 25);

            persona1.setEdad(26);

            Console.WriteLine("La nueva edad obtenida con getEdad() es: " + persona1.getEdad());


            Persona p2 = new Persona("Carlos", 22);

            if (p2.EsMayorDeEdad())
            {
                Console.WriteLine($"{p2.Nombre} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{p2.Nombre} es menor de edad.");
            }
        }
    }
}
