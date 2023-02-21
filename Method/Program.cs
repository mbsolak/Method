using System;
using System.Collections.Generic;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Elma = new();
            Elma.Id = 1;
            Elma.Adi = "Elma";
            Elma.Fiyati = 2.5;
            Elma.Aciklama = "Amasya Elması";

            Product Cilek = new();
            Cilek.Adi = "Çilek";
            Cilek.Id = 2;
            Cilek.Fiyati = 5.5;
            Cilek.Aciklama = "Taze Çilek";

            Product[] UrunList = new Product[] { Elma, Cilek };

            foreach (Product urun in UrunList)
            {
                Console.WriteLine(urun);
            }

            List<int> ss = new List<int> { 1, 2, 3 };
            List<int> ss1 = new List<int> { 5, 6, 7 };
            ss = ss1;
            Console.WriteLine(ss[0]);
            ss1[0] = 9;
            Console.WriteLine(ss[0]);

        }

       
    }
}
