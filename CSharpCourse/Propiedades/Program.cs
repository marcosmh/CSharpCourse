using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(100, DateTime.Now);
            sale.Total = -120;
            Console.WriteLine(sale.Total);
        }
    }

    class Sale
    {
        private int total = 0;
        DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                if (value < 0)
                    value = 0;

                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

       
    }


}