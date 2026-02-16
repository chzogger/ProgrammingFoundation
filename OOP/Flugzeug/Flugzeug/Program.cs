namespace Flugzeug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Doppeldecker D1 = new Doppeldecker();

            Luftfahrzeug UFO = new Luftfahrzeug();
            

            Console.WriteLine(D1.Spannweite);
            
        }
    }
}
