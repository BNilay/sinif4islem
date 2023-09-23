using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4islemodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toplam tpl = new toplam();
            tpl.Toplam(8, 3);

            fark frk = new fark();
            frk.Fark(8, 3);

            carpım crp = new carpım();
            crp.Carpım (8, 3);

            bolum blm= new bolum();
            blm.Bolum(8, 3);
            blm.Bolum(8, 3);
            
            Console.Read();
        }
    }
}
