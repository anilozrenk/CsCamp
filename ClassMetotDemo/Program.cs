using System;

namespace ClassMetotDemo
{
    class Program
    {
        static MusteriManager manager = new MusteriManager();
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = Id();
            musteri1.Ad = Name();
            musteri1.Soyad = Name();
            musteri1.Yas = Age();
            Musteri musteri2 = new Musteri();
            musteri2.Id = Id();
            musteri2.Ad = Name();
            musteri2.Soyad = Name();
            musteri2.Yas = Age();
            Musteri musteri3 = new Musteri();
            musteri3.Id = Id();
            musteri3.Ad = Name();
            musteri3.Soyad = Name();
            musteri3.Yas = Age();
            Musteri musteri4 = new Musteri();
            musteri4.Id = Id();
            musteri4.Ad = Name();
            musteri4.Soyad = Name();
            musteri4.Yas = Age();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4};
            foreach (var item in musteriler)
            {
                manager.Ekle(item);
            }

            Console.WriteLine("Tum musteriler listeleniyor...\n");

            manager.Listele(musteriler);
                        
            manager.Cikar(musteri1);
           


        }

        public static int Age(){
            return rand.Next(15,30);
        }
        public static int Id()
        {
            return rand.Next(1,10000);
        }
        public static string Name()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var genstring=new char[rand.Next(4, 7)];
            for (int i = 0; i < genstring.Length; i++)
            {
                genstring[i] = chars[rand.Next(chars.Length)];
            }
            var finalString = new String(genstring);
            return finalString;
        }













    }







}
