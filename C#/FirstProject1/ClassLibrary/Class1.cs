using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        internal string internalprop { get; set; }//publiczna tylko w obrębie projektu tego
        public string publicprop { get; set; }//publiczna w kazdym projekcie do ktorego damy zaleznosc
    }
}
