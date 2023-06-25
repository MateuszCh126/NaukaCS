using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class WordFile: File//oznacza to ze dziedziczy zmienne z klasy file
    {


        public void Print()
        {
            Console.WriteLine($"Printing: {FileName}");
        }
    }
}
