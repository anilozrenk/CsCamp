using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri()
            {
                Adi = "Anil",
                Soyadi = "Ozrenk",
                Id = 1,
                MusteriNo = "123456",
                TcNo = "11111111111",
                VergiNo = "0000001"
                
            };
            Musteri musteri2 = new TuzelMusteri() 
            { 
                Id = 2,
                MusteriNo = "45646",
                SirketAdi = "Kardesler Kebap Salonu",
                VergiNo = "1112223333" 
            };





        }
    }
}
