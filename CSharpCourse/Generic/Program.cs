using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(10);
            numbers.Add(6);

            MyList<string> strings = new MyList<string>(10);
            strings.Add("Anakin");
            strings.Add("Luke");

            MyList<People> people = new MyList<People>(6);
            people.Add(new People() { Name = "Anakin", Country = "Tatooine" });
            people.Add(new People() { Name = "Padme", Country = "Alderan" });

            Console.WriteLine("numbers -> " + numbers.GetString());
            Console.WriteLine("strings -> " + strings.GetString());
            Console.WriteLine("people -> " + people.GetString().ToString());

            Console.WriteLine("numbers --> " + numbers.GetElement(11));
            Console.WriteLine("strings --> " + strings.GetElement(0));
            Console.WriteLine("people --> " + people.GetElement(1));

        }
    }

    public class People
    {
        public string Name;
        public string Country;

        public override string ToString()
        {
            return $"Nombre: {Name},  Pais: {Country}";
        }

    }

    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T e)
        {
            if(_index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }   
            
        }

        public T GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(T);
        }

        public string GetString()
        {
            int i = 0;
            string result = "";
            while(i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }
            return result;
        }
    }
}