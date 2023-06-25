using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    abstract class File //ustawiamy jako abstrakcyjna poniewaz nie chcemy tworzyc z niej elemetnow tylko chcemy zeby dziedziczyla to innych klas swoje wlasciwosci
    {
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime CreatedOn { get; set; }
        protected string ProtectedProp { get; set; }//chodzi o to ze jest prywatne dla wszystkich oprocz klas ktore go dziedzicza wiec calkiem spoko opjca
        public abstract void Compress();//poniewaz jest to metoda abstrakcyjna to kazda klasa ktora dziedziczy musi zaimplementowac te metode inaczej bedzie wyrzucac blad
        

    }
}
