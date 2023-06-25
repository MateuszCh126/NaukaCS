using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class File
    {
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime CreatedOn { get; set; }

        protected string ProtectedProp { get; set; }//chodzi o to ze jest prywatne dla wszystkich oprocz klas ktore go dziedzicza wiec calkiem spoko opjca
    }
}
