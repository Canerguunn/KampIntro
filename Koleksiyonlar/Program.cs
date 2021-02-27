using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Şakir", "Can", "Ergün",};

            foreach (string item in isimler)
            {
                Console.WriteLine(item);
            }

            isimler.Add("Can");


        }
    }
}
