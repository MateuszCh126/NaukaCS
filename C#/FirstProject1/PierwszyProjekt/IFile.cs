using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    interface IFile
    {//nie trzeba dawac public itp wiec jest czysciej i przejrzyscie
        string FileName1 { get; set; }
        int FileSize1 { get; set; }
        DateTime CreatedOn1 { get; set; }
        void Compress();//poniewaz jest to metoda abstrakcyjna to kazda klasa ktora dziedziczy musi zaimplementowac te metode inaczej bedzie wyrzucac blad

    }
}
