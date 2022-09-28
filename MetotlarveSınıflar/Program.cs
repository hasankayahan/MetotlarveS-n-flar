using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarveSınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Kış Elması";
            urun1.Fiyatı = 12;

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Aciklama = "Kış Armutu";
            urun2.Fiyatı = 15;

            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine("-----------");


            }

            SepeteManager sepetmanager = new SepeteManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
           



            Console.Read();
            
        }
    }
}
