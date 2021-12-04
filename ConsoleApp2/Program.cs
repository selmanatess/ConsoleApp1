using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1=new Urun();
            Urun1.Adi = "elma";
            Urun1.Id = 1;
            Urun1.Fiyatı = 12;
            Urun1.Aciklama = "amasya elması";
            Urun urun2=new Urun();
            urun2.Adi = "muz";
            urun2.Id = 2;
            urun2.Aciklama = "serik muzu";
            urun2.Fiyatı = 16;

            Urun[] urunler = new Urun[] { Urun1,urun2, };


            foreach  (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("---------metodlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(Urun1);
            sepetManager.ekle(urun2);


            Console.ReadLine(); 
        }
    }
}
