using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class ExcelFile: File//oznacza to ze dziedziczy zmienne z klasy file
    {
        public void GenerateRaport()
        {
            Console.WriteLine($"File Raport: {FileName}");
        }
    }
}
