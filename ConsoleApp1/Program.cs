using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1=new kurs();
            kurs1.Egitmen = "selman ates";
            kurs1.KursAdi = "programlama";
            kurs1.izlenmeoranı = 45;


            kurs kurs2=new kurs();
            kurs2.KursAdi = "matematik";
            kurs2.Egitmen = "ramazan";
            kurs2.izlenmeoranı = 85;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
            Console.ReadLine(); 

        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string  Egitmen{ get; set; }
        public int izlenmeoranı { get; set; }


    }
}
