using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeEnumy
{
    enum Gender : byte // domyslnie jest to int ale mozemy sobie okreslac typ zmiennych
    {
        /*
        Male,
        Female
        *///ogolnie to to moze tak byc bo domyslnie sa przepisywane wartosci od 0 czyli Male to 0 a Female 1
        Male = 1,
        Female = 2 //mozemy rowniez jawnie zmienic przypisane wartosci co do obiektow znajdujachych sie w enum
    }
}
