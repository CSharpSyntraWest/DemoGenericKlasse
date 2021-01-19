using System;

namespace DemoGenericKlasse
{
    class Factory<T>
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
    class Program
    {
        static void Main(string[] args)
        {
            Factory<int> intFactory = new Factory<int>();
            Console.WriteLine("Waarde van _field int :" + intFactory.Property);
            Factory<DateTime> dateTimeFact = new Factory<DateTime>();
            Console.WriteLine("Waarde van _field DateTime:" + dateTimeFact.Property);
            Console.WriteLine(intFactory.Methode2(5));

            Console.ReadKey();
        }
    }
}
