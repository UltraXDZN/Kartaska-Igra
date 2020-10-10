using System;

namespace KartaskaIgra
{
    class Program
    {
        static void Main(string[] args)
        {
            float brojac = 0;
            while (brojac < 31)
            {
                try
                {
                    Console.Write("Unesite vrijednost karte: ");
                    float nova_karta = Convert.ToInt32(Console.ReadLine());
                    brojac += nova_karta;
                }
                catch
                {
                    Console.WriteLine("Unesite broj!");
                } 
                
            }
            Console.WriteLine(brojac == 31 ? "Pobjedili ste!" : "Izgubili ste!");
            Console.ReadKey();
        }
    }
}
