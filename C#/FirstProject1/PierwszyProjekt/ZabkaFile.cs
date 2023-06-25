using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class ZabkaFile: IFile 
    {
        public string FileName1 { get; set; }
        public int FileSize1 { get; set; }
        public DateTime CreatedOn1 { get; set; }
        public void Compress()
        {
            Console.WriteLine("hejka");
        }
    }
}//porwnaj sobei do innych klas z file w nazwie 
