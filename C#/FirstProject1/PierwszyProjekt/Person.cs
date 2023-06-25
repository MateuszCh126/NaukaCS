using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class Person
    {
        
        public Person(string fristname,string lastName) 
        {
            FristName = fristname;
            LastName = lastName;
            Console.WriteLine("jakis szit kostruktor pierwszy");
            Count++;
        }
        public Person(DateTime dateOfBirth1, string fristname, string lastName) : this(fristname, lastName)
        {
            SetDateOfBirth(dateOfBirth1);
            Console.WriteLine("drugi szit");
        }

        public string FristName;
        public string LastName;
        private DateTime dateOfBirth;
        //public string ContactNumber { get; set; } //i cyk i juz zrobione ale nei mozna sprawdzac czy dane sa okej wiech mech teoche wiec wrocimy do funkcji
        private string contactNumber;
        public static int Count = 0;//static sprawia ze Count odnosi sie do klasy person a nie do obeitku w niej zawartego
        public string ContactNumber
        { 
            get { return contactNumber; }
            set {
                    if (value.Length != 9)
                    {
                        Console.WriteLine("Zły numer kontakowy");
                    }
                    else
                    {
                        contactNumber = value;
                    }
                     
                } //wlasciwosci klasy set i get tak zwanne akcesory dzieki temu contactNumber jest prywanty ale mozemy z niego korzystac jakby byl publiczny lecz mimo wszystko chronimy go
        }
        //wszystko cool is spoko ale mozna szybciej pa na deklaracje zmiennych
        public void SetDateOfBirth(DateTime Date)
        {
            if(Date > DateTime.Now)
            {
                Console.WriteLine("Zła data urodzenia");
            }
            else
            {
                dateOfBirth = Date;
            }
        }
       /* public DateTime GetDateOfBirth() 
        {
            return dateOfBirth;
        }*///jakis stary zapis my robimy expression body
        public DateTime GetDateOfBirth() => dateOfBirth;//expression body

        public void SayHi()
        {
            Console.WriteLine($"Hejka jestem {FristName} {LastName} urodzilem sie {GetDateOfBirth()} aha spoko ok {ContactNumber}");
        }

    }
}
