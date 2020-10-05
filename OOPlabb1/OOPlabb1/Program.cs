using System;

namespace OOPlabb1
{
    class Program
    {
        static void Main(string[] args)
        {

            var kund = new Kund();
            var produkt = new Produkt();
            produkt.produktTyp = "småbarn";
            kund.kundKorg.Add(produkt);
            
            foreach(var prod in kund.kundKorg){
                Console.WriteLine(prod.produktTyp);
            }
        }
    }
}
