using System;

namespace classs
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "tuvalet egitimi";
            kurs1.IzlenmeOrani = 11;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "cisimiz tuvalette";
            kurs2.IzlenmeOrani = 59;

            

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2};

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
                Console.WriteLine(item.IzlenmeOrani);

            }



        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}

        

