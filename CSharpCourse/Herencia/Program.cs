using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("Anakin",30,"Cirujano");
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());

            Dev dev1 = new Dev("Luke", 20, "Java");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());


        }

        


    }

    class People
    {
        private string _name;
        private int _age;

        public People(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string GetInfo()
        {
            return _name + " " + _age;
        }

    }

    class Doctor : People
    {
        private string _speciality;

        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            _speciality = speciality;
        }

        public string GetData()
        {
            return GetInfo() + " " + _speciality;
        }

    }

    class Dev : People
    {
        private string _language;

        public Dev(string name, int age, string language) : base(name, age)
        {
            _language = language;
        }

        public string GetData()
        {
            return GetInfo() + " " + _language;
        }
    }
}