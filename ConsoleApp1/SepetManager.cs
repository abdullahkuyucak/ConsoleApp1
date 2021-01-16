using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : "+ product.Adi);

        }
        public void Ekle2(string urunAdi,string urunAciklamasi,double urunFiyati)

        {
            Console.WriteLine("Sepete eklendi"+urunAdi);
        }
    }
}
