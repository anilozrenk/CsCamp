using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("ID: "+musteri.Id+ "\nName: " + musteri.Ad + " " + musteri.Soyad + "\nAge:" + musteri.Yas +"\nHas been added\n**********\n" );
        }
        public void Cikar(Musteri musteri)
        {
            
            Console.WriteLine("ID: " + musteri.Id + "\nName: " + musteri.Ad + " " + musteri.Soyad + "\nAge:" + musteri.Yas + "\nHas been deleted\n**********\n");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID: " + musteri.Id + "\nName: " + musteri.Ad + " " + musteri.Soyad + "\nAge:" + musteri.Yas + "\n\n");
            }
        }
    }
    


    

    
}
