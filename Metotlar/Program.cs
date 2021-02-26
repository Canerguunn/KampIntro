using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";

            Product urun2 = new Product();
            urun2.Adi = "Armut";

            Product[] Products = new Product[] {urun1,urun2 };

            foreach (Product urun in Products)
            {
                Console.WriteLine(urun.Adi);
            }

            SepetManager seperManager = new SepetManager();
            seperManager.Ekle(urun1);
            seperManager.Ekle(urun2);
        }
    }
}
