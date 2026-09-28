namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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
