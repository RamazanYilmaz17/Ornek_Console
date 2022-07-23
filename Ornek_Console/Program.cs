using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Ramazan";
            kml.SOYAD = "Yılmaz";
            kml.MEMLEKET = "Gaziantep";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Console.Read();
        }
    }
}
