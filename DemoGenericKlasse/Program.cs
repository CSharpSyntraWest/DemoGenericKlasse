using System;
using System.Collections;

namespace DemoGenericKlasse
{
    class Factory<T>  where T : IPersoon//,IEnumerable
    {
        private T _field;
        public Factory()
        {
            _field = default;
        }
        public Factory(T field)
        {
            _field = field;
        }
        public T Property
        {
             get {return _field;}
             set {_field=value;}
        }
        public T Methode1(T param1, T param2, bool eerste)
        {
            if (eerste) return param1;
            else return param2; 
        }
        public string Methode2(T param)
        {
            return "Naar string:" + param.ToString();
        }
    }
    class Persoon : IPersoon//,IEnumerable
    {
        public string Naam { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Docent : Persoon { }
    class Student:Persoon {   }
    class Program
    {
        static void Main(string[] args)
        {
            Factory<Persoon> persoonFactory = new Factory<Persoon>();
            Console.WriteLine("Waarde van _field int :" + persoonFactory.Property);
            Factory<Docent> docentFactory = new Factory<Docent>();
            Console.WriteLine("Waarde van _field int :" + docentFactory.Property);
            Factory<Student> studentFactory = new Factory<Student>();
            Console.WriteLine("Waarde van _field int :" + studentFactory.Property);
            //Factory<DateTime> dateTimeFact = new Factory<DateTime>();
            //Console.WriteLine("Waarde van _field DateTime:" + dateTimeFact.Property);
            //Console.WriteLine(intFactory.Methode2(5));
            //Factory<DateTime> dateTimeFact2 = new Factory<DateTime>(DateTime.Today);
            //Console.WriteLine("Waarde van _field DateTime2:" + dateTimeFact2.Property);
            Console.ReadKey();
        }
    }
}
