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
                Console.WriteLine("Unesite vrijednost karte: ");
                float nova_karta = Convert.ToInt32(Console.ReadLine());
                brojac += nova_karta != 0 ? nova_karta : 0;
            }
            Console.WriteLine(brojac == 31 ? "Pobjedili ste!" : "Izgubili ste!");
        }
    }
}
