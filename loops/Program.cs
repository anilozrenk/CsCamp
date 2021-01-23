using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "kiki", "fdasf", "bgfbf", "ytuyt", "ghghg" };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }




        }
    }

}   