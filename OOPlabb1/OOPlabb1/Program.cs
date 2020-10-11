using System;

namespace OOPlabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            var kund = new Kund();
            do
            {
                Console.WriteLine("Du, mjölkhjärna, välj nåt av följande");
                Console.WriteLine("1 = Lägg till kund och produkter");
                Console.WriteLine("2 = Skriv ut produkter i kundkorg");
                Console.WriteLine("9 = Avsluta och drick mjölk");

                val = Convert.ToInt32(Console.ReadLine());

               
                var produkt = new Produkt();

                if (val == 1)
                {
                    produkt.produktTyp = "småbarn";
                    kund.kundKorg.Add(produkt);
                    Console.WriteLine("Produkt tillagd");
                }
                if (val == 2)
                {
                    
                    foreach (var prod in kund.kundKorg)
                    {
                        Console.WriteLine(prod.produktTyp);
                    }
                }
            } while (val != 9);
            Console.WriteLine("Programmet är avlsutat. Gå och drick mjölk");
        }
    }
}
