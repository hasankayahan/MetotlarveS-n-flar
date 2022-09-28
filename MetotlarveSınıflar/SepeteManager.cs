using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarveSınıflar
{
    internal class SepeteManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:  " + urun.Adi);
        }
        
    }
}
