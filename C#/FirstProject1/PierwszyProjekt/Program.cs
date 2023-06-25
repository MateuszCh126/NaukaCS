using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MojeEnumy;//bo ten bo nowy namespace w osobnym folderze to trzeba zaimpoortowac ladnie
using ClassLibrary;//importuje klase z innego projektu wazne zeby dodac inny projekt do zaleznosci

namespace PierwszyProjekt
{

    internal class Program
    {
         static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1999,1,3),"jan","kowalski"),
                new Person(new DateTime(2000,3,2),"Karol","Smith"),
                new Person(new DateTime(1997,5,1),"Kuba","Klerowic"),
                new Person(new DateTime(1994,9,3),"Andrzej","Gerbiskacz"),
                new Person(new DateTime(1993,7,1),"Stefan","Sopolicki"),
                new Person(new DateTime(1994,4,2),"Karol","Sopolski"),
                new Person(new DateTime(1991,7,2),"Adam","Jenrak"),
                new Person(new DateTime(1993,7,3),"Szymon","Redakan"),
                new Person(new DateTime(1969,5,3),"Krystian","Robertly"),
                new Person(new DateTime(1989,3,3),"Radek","Asembly"),
                new Person(new DateTime(2004,2,3),"Bob","Leritnicki"),
            };
            return employees;
         }
         static void ShowList(List<int> list)
        {
            Console.WriteLine("******Lista******");
            foreach (int element in list) 
            {
                Console.Write($"{element}");
                Console.Write($",");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Ale jazda nadaje opis dla main i jak na niego najedziesz to masz moj opis
        /// </summary>
        /// <param name="args">a tutaj opis dla parametru args</param>
        private static void Main(string[] args)
        {
            #region Wypisiwanie
            //Wypsiuje bez enter
            Console.Write("Hello, ");
            Console.Write("World!!!");

            //Wypisuje z zakonczeniem linijki
            Console.WriteLine("Hello, ");
            Console.WriteLine("World!!!");
            Console.Write("Type in your name: ");
            #endregion
            #region pobieranie i wypisawnie danych
            //Pobranie danych od uztykownika i zapisanie
            string name = Console.ReadLine();
            //Wypisanie zmiennej
            Console.WriteLine(name);
            #endregion
            #region przykladowe zmienne
            //Przykladowe typy zmiennych
            string someText = "SomeText";//tekst
            char Jchar = 'j';//znak
            char JcharUniCode = '\u006A';//znak j zapisany w UniCode
            bool isUserReady = true;//Boolean czyli 0 1 czyli prawda fałsz
            DateTime now = DateTime.Now;//Data obecna
            DateTime DateOfBirth = new DateTime(1999, 6, 2);//przypisanie jakies daty
            #endregion
            #region o liczbach calkowitych
            //Liczby Całkowite
            byte maly = 255;//0-255 zajmuje 8 bitow pamieci
            sbyte malyalewariat = -128;//przyjmuje wartosci od -128 do 127 rowniez 8bitow ale wlicza liczby ujemne
            short prawie_bestia = 32767;//przyjmuje wartosci od  -32 768 do 32 767 16bitow
            ushort prawie_bestia2 = 65535;//przyjmuje wartosci od  0 do 65 535 16bitow
            int masnoni = 2147483647;//przyjmuje wartosci od -2 147 483 648 do 2 147 483 647 32bity 
            uint mosznomi = 4294967295;//przyjmuje wartosci od 0 do 4 294 967 295 32bity
            long zaduzojuz = -9223372036854775808;//przyjmuje wartosci od -9 223 372 036 854 775 808 do 9 223 372 036 854 775 807 64bity
            ulong megaduzo = 18446744073709551615;//przyjmuje wartosci od 0 do 18 446 744 073 709 551 615 64bity
            #endregion
            #region o liczbach zmiennoprzecinkowych
            //Liczby zmiennoprzecinkowe
            //one roznia sie wielkoscia pamieci i precyzja
            float floatNumber = 1.5F;//trzeba dodac F(tak zwany safiks nwm jak sie to pisze) zeby wskazac ze jest to float glupie bardzo to ejst 
            decimal decimalNumber = 1.5M;//ten sa ma M bo czemu by nie
            double doubleNumber = 1.5;//nie trzeba nic dodawac 
            #endregion
            #region string
            //o string
            string message1;//mozesz se zadeklarowac bez przypisania ale nie mozesz jej nigdzie uzyc
            string message2 = null;//przypis se null to jest wszystko git dziala bez bledu mozna tak nic nie ma ale nic to tez wartosc pamietaj i nic to nie 0
            string message3 = string.Empty;//pusty string Empty!=null to nie jest to samo tu i tu nic nie ma ale to inne rzeczy i Empty jest statyczne
            string cudzyslow = "He said \"hey\"";//dzajesz se krzywa linie i cyk oni juz wiedza ze to jest cudzyslow  w tekscie a nie zakonczenie stringa
            string WindowsLocation = "c:\\desktop";//jak chcesz uzyc tej krzywej linie zeby ja wypisalo to daj dwie es
            string WindowsGlebszeGnaizdo = @"c:\User\desktop\Janek\Programownie\Projekty\C#\Projekt1";//jak duzo krzywych lini to daj malpke i bedzie git
            message1 = "przykladowy tekst";//mozesz se pozniej przypisac es

            //Konkatenacja Stringow(mam nadzieje ze dobrze to pisze)
            string polacznie = string.Concat(cudzyslow, WindowsLocation, WindowsGlebszeGnaizdo);//se mozesz polaczyc istniejace
            string drugiepolaczenie = string.Concat(cudzyslow, "Hejka geju", name);//mozesz se tez na szybko w nawiasach tekst napisac

            //dodaj se plusikiem
            string jakczlowiek = name + " no hejka co tam u ciebie slychac skad te zwatpienie";//jak czlowiek mzoesz se dodac plusikiem

            //Interpolacja stringow
            string interpol = $"No Hejka {name} geju co tam u ciebei";//mozesz se w srodku stringa tak o wrzucic inny za pomoca klamerek tylko pamietaj o znaku dolara

            //troche o wydajnosci
            string tekst1 = "Hello";
            tekst1 = tekst1 + "janku";//dobra wiec tak w pamieci i tak zostaje te Hello on nie nadpisuje tamtego miejsca w pameici tylko tworzy nowe przez co zapycha pamiec i obniza wydjanosc wiec tego nie lubimy

            StringBuilder sb = new StringBuilder("hejka naklejka ");//deklaracja generalnie on dynamicznie rozszerza pamiec juz istniejaca a nie towrzy nowa
            sb.Append(tekst1);
            sb.Append(" jol");
            sb.Append(" gejek");//dolaczanie tekstu

            string result = sb.ToString();//przypsianie do stringa
            Console.WriteLine(result);//wypisanie
            #endregion
            #region operatory algebraiczne i logiczne
            //operatory
            int resultat;
            int x = 10;
            int y = 20;
            //dodawnie
            resultat = x + y;
            Console.WriteLine(resultat);
            //odejmowanie 
            resultat = x - y;
            Console.WriteLine(resultat);
            //mnozenie
            resultat = x * y;
            Console.WriteLine(resultat);
            //dzielenie
            resultat = x / y;
            Console.WriteLine(resultat);
            //reszta z dzielenia
            resultat = x % y;
            Console.WriteLine(resultat);

            //oglem c# zna kolejnosc wykonywania dzialan czyli ze 2 + 2 * 5 =12
            int value = 2 + 2 * 5;
            Console.WriteLine(value);

            //ogarnia tez nawiasy  (2 + 2) * 5 =20
            int value2 = (2 + 2) * 5;
            Console.WriteLine(value2);

            //inkremetnacja
            x = x++;
            Console.WriteLine(x);
            //dekrementacja
            x = x--;
            Console.WriteLine(x);

            //w miare wazne
            x = ++x;//odrazu zwieksza
            x = x++;//dopiero po tej linijce sie zwiekszy znaczy to ze jak to wypiszesz w tej linijce to bedzie nie zwieksze dopiero jak osobno to wypisze to bedzie zwiekszone

            bool Wynik;
            int z = 1;
            int c = 2;

            Wynik = (z == c);
            Console.WriteLine(Wynik);

            Wynik = (z != c);
            Console.WriteLine(Wynik);

            Wynik = (z < c);
            Console.WriteLine(Wynik);

            Wynik = (z <= c);
            Console.WriteLine(Wynik);

            Wynik = (z > c);
            Console.WriteLine(Wynik);

            Wynik = (z >= c);
            Console.WriteLine(Wynik);
            Console.WriteLine("nowy temat");

            //boolean tera
            bool a = true;
            bool b = false;

            Wynik = a && b;//and
            Console.WriteLine(Wynik);

            Wynik = a || b;//or
            Console.WriteLine(Wynik);

            Wynik = !a;//not
            Console.WriteLine(Wynik);

            //Ternary conditional operator(if else)
            int GreatNumber = x > y ? x : y;
            Console.WriteLine(GreatNumber);
            #endregion
            #region if-else
            //if
            Console.Write("Podaj swoja date urodzenia: ");
            string output = Console.ReadLine();
            int age = int.Parse(output);
            bool isUserOver18 = DateTime.Now.Date.Year - age >= 18;
            if (isUserOver18)
            {
                Console.WriteLine("witam szanownego pana");

            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//ogolem to weisz se jest else ale tylko jesli warunek jest spelniony aha i jesli jest niedziela to kolejny else sie nie wykona
            {
                Console.WriteLine("mordzia dzis niedziele to nieczynne");
            }
            else
            {
                Console.WriteLine("gowniarzu spadaj stad idz sie uczyc czy cos");
            }
            #endregion
            #region switch
            //switch jest czesto uzywany jako alternatywa dla if else szczegolnie jesli pojedyncznie wyrazenie jest testowane pod katem 3 lub wiecej warunkow
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("mordzia poniedzialeczek jest");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("mordzia wtoreczek");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("czwarteczek");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("piątunio mordzia");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("niedziela no");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("mmm niedziela");
                    break;
                default://deafult wykona sie tylko wtedy jesli zaden case nie spelnia warunku 
                    Console.WriteLine("srodek tygonia sroda jak w tym serialu ciekawe czy dla nas zatanczy");
                    break;
            }
            #endregion
            #region Konwersja typów i rzutowanie
            Console.Write("Rok urodzenia znowu podaj bambiku: ");
            string output1 = Console.ReadLine();
            int age1 = int.Parse(output1);//ogolem wszystko spoko ale jak chlop ci napisze literki zamiast cyferek to shit a nie program wiec trzeba to zrobic inaczej
            if (int.TryParse(output1, out age1))//tak sprawdzi czy da rade zmienic to na int jak tak to masz wszysyko git a jak nie to naura
            {
                int AgeNow1 = DateTime.Now.Year - age1;
                Console.WriteLine(AgeNow1);
            }
            else
            {
                Console.WriteLine("czemu wpisujesz cos innego niz rok urodzenia debilu");
            }
            float floatValue = float.Parse(output1);
            short shortValue = short.Parse(output1);
            int AgeNow = DateTime.Now.Year - age1;
            Console.WriteLine(AgeNow);

            //ogolnie z typami liczbowymi jest prosciej
            byte byteValue = 100;
            int intValue = byteValue;//i cyk konwersja szybka i prosta poniewaz int moze bez problemu pomiescic byte
            byte byteValue2 = (byte)intValue;//na odwrot nie mozna chyba ze w nawiasach dasz typ na ktory chcesz zamienic to wteyd git tylko uwazaj zeby nie dac wiekszej liczby niz byte obsluguje 
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;//se mozesz nawet zmiennoprzecinkowa zamienic
            string stringValue = intValue2.ToString();//tak se stringa zrobisz
            #endregion
            #region operajca na bitach od marcina 
            int jakakoliwek = 2;
            jakakoliwek = jakakoliwek << 2;//przesuniecie bitow po lewej stronie << o prawa strone
            Console.WriteLine(jakakoliwek);
            #endregion
            #region tablice
            string[] cars = { "Volvo", "BMW", "Audi", "Toyota", "Ferrai", "Hyundai", "Mazda" };
            Console.WriteLine(cars[0]);
            int dlugosc = cars.Length;
            cars[6] = "Tesla";
            Console.WriteLine(cars[cars.Length - 1]);
            #endregion
            #region Pętle
            string[] auta = { "Volvo", "BMW", "Audi", "Toyota", "Ferrai", "Hyundai", "Mazda" };
            int i = 0;
            while (i < auta.Length)
            {
                Console.WriteLine(auta[i]);
                i++;
            }

            string dane;
            Console.Write("napisz x zeby wyjsc: ");
            do
            {
                dane = Console.ReadLine();
                Console.WriteLine($"hejka{dane}");
            } while (dane != "x");

            for (int f = 0; f < auta.Length; f++)
            {
                Console.WriteLine(auta[f]);
            }

            foreach (string auto in auta)
            {
                Console.WriteLine(auto + " ale furka wzzium");
            }
            #endregion
            #region zadanie polegajace na przyjmowaniu danych od uzytkownika dopoki nie poda 0 oraz sumowanie podanych cyfr oraz znalezienie jak najwiekszej
            Console.WriteLine("***************************************");
            int suma = 0;
            Console.Write("Podaj Liczbe: ");
            int podanaLiczba = int.Parse(Console.ReadLine());
            int? naj = null;
            while (podanaLiczba != 0)
            {
                if (naj == null || podanaLiczba > naj)
                {
                    naj = podanaLiczba;
                }
                Console.Write("Podaj Liczbe: ");
                podanaLiczba = int.Parse(Console.ReadLine());
                suma = suma + podanaLiczba;
            }
            Console.WriteLine(naj);
            Console.WriteLine(suma);
            #endregion
            #region Enum
            //osobny plik o nazwie Gender.cs
            Console.Write("jaka plec wariacie 1=Mezczyzna 2=baba: ");
            string plec = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), plec);//jest wysoko dobra wiec tak musimy sparsowac sobie string na enum i muismy wybrac typ enuma czyli u nas Gender po przecinku podajemy output uzytkownika ktory wpisal w konsole a pozniej w nawiasie jawnie rzutujemy na typ Enuma ktorym jest Gender
            if (userGender == Gender.Female)
            {
                Console.WriteLine("ty lepiej idz do kuchni a nie przy komputerze siedzisz");
            }
            else
            {
                Console.WriteLine("dobry wybór przyjacielu");
            }
            #endregion
            #region nullable
            Console.Write("Podaj Ulubiona liczbe: ");
            int? FavouriteNoumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Twoja Ulubiona Liczba to " + (FavouriteNoumber.HasValue ? FavouriteNoumber.Value.ToString() : ""));
            #endregion
            #region Try=Catch_finlly
            string[] brum = { "Volvo", "BMW", "Audi", "Toyota", "Ferrai", "Hyundai", "Mazda" };
            try//tutaj kod sprobuje cos zrobic i jak cos bedzie nie tak czyli wyskoczy tak zwany wyjatek kod odrazu przejdzie do catch
            {
                Console.WriteLine("try przed wyjatkiem");
                brum[7] = "Tesla";//IndexOutOfRangeException taki o to wyjatek sie pojawia bo chce dodac elemnmt do tablicy poza jej zakresem
                Console.WriteLine("try po wyjatku");
            }
            catch (IndexOutOfRangeException e)//wykonuje sie w razie wyjatku
            {
                Console.WriteLine("catch dla poza zakresem tablicy");
            }
            catch (Exception e) // ogolnie to jak jest wyjatek to kod sprawdzi gdzie pasuje wyjatek w powyzszym catch mamy tylko out of range czyli jak ot bedzie out of range to wykona sie on a jak nie to ten bo ten jest ogolny dla kazdego wyjatku
            {
                Console.WriteLine("catch dla jakiekolwiek wyjatku");
            }
            finally//to sie wykona zawsze po prostu nioe wazne czy jest wyjatek czy nie ma
            {
                Console.WriteLine("no hejka " + "Cleanup");
            }
            Console.WriteLine("wyjscie z try catch");
            #endregion
            #region JakisZydek musi tutaj ten urodzinki no
            DateTime Teraz = DateTime.Now;//Data obecna

            Console.Write("Podaj date urodzin (DD.MM.YYYY): ");
            string DateOutput = Console.ReadLine();
            DateTime Urodzinki = DateTime.Parse(DateOutput);

            TimeSpan timeSpan = Teraz - Urodzinki;
            Console.WriteLine($"tyle dni temu sie urodziles {timeSpan.TotalDays}");
            #endregion
            #region Regex
            //Regexr.com
            /*
            ^Dzień wszystko co zaczyna sie na dzien
            dobry$ wszystko co konczy sie na dobry
            ^dzien dobry$ wszystko co zaczyna i konczy sie na dzien dobry
            dobry kazde dobry w tekscie
            */
            Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            string mail = "test.test@gmail.com";
            bool IsMatch = regex.IsMatch(mail);
            Console.WriteLine(IsMatch);
            #endregion
            #region Nauka O Klasach
            Person Aleksander = new Person("Aleksander", "Szlosek");
            Aleksander.SetDateOfBirth(new DateTime(2005, 01, 04));
            Aleksander.ContactNumber = "780094046";
            Aleksander.SayHi();
            Person Jacek = new Person(new DateTime(2005, 03, 01), "Jacek", "Keliwar");
            Jacek.SayHi();
            #endregion
            #region Dziedziczenie Klasy
            //ogolnie to pliki ktore zawieraja File w nazwie
            WordFile wordFile = new WordFile();
            wordFile.CreatedOn = DateTime.Now;
            wordFile.FileName = "Word-File";
            wordFile.FileSize = 100;
            wordFile.Print();

            ExcelFile excelFile = new ExcelFile();
            excelFile.FileName = "Excel-File";
            excelFile.FileSize = 100;
            excelFile.CreatedOn = DateTime.Now;
            excelFile.GenerateRaport();

            Class1 test = new Class1();//patrz prokelt ClassLibrary 
            test.publicprop = "hejka";
            #endregion
            #region Klasy Abstrakcyjne
            //File.cs
            #endregion
            #region Klasy Interfejs 
            //mozna sobie wyobrazic ze Interfejs to w 100% klasa abstrakcyjna czyli kazda funkcja kazda zmienna zawarta w interfejsie musi byc zawarta w klasach ktore ją dziedziczą
            //roznice pomiedzy klasa abstrakcyja a interfejsem mozemy dziedziczyc tylko jedna klase bazowa a interfejsow mozemy implementowac wiele bo interfejsty implementujemy a nie dziedziczymy
            //w interfejsie nie mozemy miec konstruktora w klasie mozemy ustawic public private protected internal abstratc a w interfejsie wszystko jest ustawione na abstract public

            #endregion
            #region Polimorfizm Lulu naziwaznie
            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle(), };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            #endregion
            #region Kolekcje
            // kolekcje to Dictionary i Hashtable pary typu klucz wartosc | List tutaj ogolnie dynamiczny dostep dodawnie usuwanie sortowanie grupowanie elementow | Queue i Stack frist in last out i last in frist out 
            List<int> list = new List<int>() { 7 , 1 ,20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20, 1, 20,1,3,2,4,5,88,4,234,32,123,52346,624,314234,53252,624234,6232,42,235,62,236,262,6263,232,62,623256,262,1,3343,256,24,5,632 };//<> zawiera typ ogolny (generyczny) moze byc nawet lista typow person {} mozemy dodwawac elementy listy juz przy deklaracji
            list.Add(6);
            //patrz nad funkcjie main
            Console.Write("Dodaj element do Listy: ");
            int elemencik = int.Parse(Console.ReadLine());
            list.Add(elemencik);
            ShowList(list);
            //usuwanie z listy na 4 rozne sposoby
            list.RemoveAt(0);//usuwa liczbe o danym indeksie
            //list.RemoveAll(); usuwa wszystko z listy chyba ze damy mu okreslony warunek w nawiasy to usunie wszystkie elementy spelniajace dany warunek
            list.Remove(1);//usuwa pierwszy napotkany element ktory podajemy w nawiasach w tym przypadku zniknie pierwsza jedynka
            list.RemoveRange(0, 2);//pierwsza liczba w nawiasie okresla od ktorej pozycji a kolejna ile cyfr od tej pozycji
            list.Sort();
            ShowList(list);
            #endregion
            #region
            List<Person> employees=  GetEmployees();
            #endregion
        }
    }
}
