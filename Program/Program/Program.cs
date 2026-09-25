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
        }
    }
}
