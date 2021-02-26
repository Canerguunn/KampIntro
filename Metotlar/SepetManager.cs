using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product) {
            Console.WriteLine("sepete eklendi" + product.Adi);
        }
    }
}
