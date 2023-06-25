using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class ExcelFile: File//oznacza to ze dziedziczy zmienne z klasy file
    {
        public override void Compress()//za pomoca override implementujemy metode abstrakcyjna z pliku file ktora jest wymagana
        {
            Console.WriteLine("Compressing");
        }
        public void GenerateRaport()
        {
            Console.WriteLine($"File Raport: {FileName}");
        }
    }
}
