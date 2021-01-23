using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string detail = "Amasya elması";
            string[] meyveler = new string[] { };

            Product elma = new Product();
            elma.Adi = "Elma";
            elma.Fiyati = 15;
            elma.Aciklama = "Amasya elması";

            Product karpuz = new Product();
            karpuz.Adi = "Karpuz";
            karpuz.Fiyati = 80;
            karpuz.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] {elma, karpuz};

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("**********");
                

            }
            Console.WriteLine("*****Methodlar*****\n");

            SepetManager sepetManager = new SepetManager();
            
            foreach (var product in products)
            {
                sepetManager.Ekle(product);
            }
            Console.WriteLine("**********");

            sepetManager.Ekle2("Armut", "Yesil armut", 12);
        }
    }





















}
