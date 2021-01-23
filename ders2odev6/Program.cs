using System;

namespace ders2odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product();

            product1.itemCategory = "Electronics";
            product1.itemName = "Xiaomi Mi Box S";
            product1.itemPrice = 570;
            product1.itemStock = 20;

            var product2 = new Product();

            product2.itemCategory = "Outdoor";
            product2.itemName = "Stanley Thermos";
            product2.itemPrice = 500;
            product2.itemStock = 120;

            var product3 = new Product();

            product3.itemCategory = "Smart Home";
            product3.itemName = "Philips Hue Signe";
            product3.itemPrice = 1000;
            product3.itemStock = 9;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var item in products)
            {
                Console.WriteLine("Cathegory: " + item.itemCategory + "\n" + "Product: " + item.itemName + "\n" + "Price: " + item.itemPrice + "\n" + "Stock: " + item.itemStock +"\n\n");
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Cathegory: " + products[i].itemCategory + "\n" + "Product: " + products[i].itemName + "\n" +
                    "Price: " + products[i].itemPrice + "\n" + "Stock: " + products[i].itemStock + "\n\n");
            }
           
            int n = 0;
            while (n<products.Length)
            {

                Console.WriteLine("Cathegory: " + products[n].itemCategory + "\n" + "Product: " + products[n].itemName + "\n" +
                    "Price: " + products[n].itemPrice + "\n" + "Stock: " + products[n].itemStock + "\n\n");

                n++;
            }



        }
    
    }

    class Product
    {
        public string itemCategory { get; set; }
        public string itemName { get; set; }
        public int itemPrice { get; set; }
        public int itemStock  { get; set; }
    }


}

