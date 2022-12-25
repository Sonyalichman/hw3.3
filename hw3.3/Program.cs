using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Converter
    {
        protected decimal Dollar;
        protected decimal Euro;
        public Converter(decimal Dollar, decimal Euro)
        {
            this.Dollar = Dollar;
            this.Euro = Euro;
        }
        public decimal GetDollar() { return this.Dollar; }
        public decimal GetEuro() { return this.Euro; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 to convert dollars to hryvnas.");
            Console.WriteLine("Enter 1 to convert euro to hryvnas.");
            Console.WriteLine("Enter 2 to convert hryvnas to dollars.");
            Console.WriteLine("Enter 3 to convert hryvnas to euro.");
            string valute = Console.ReadLine();
            if (valute == "0" || valute == "1" || valute == "2" || valute == "3")
            {
                Console.WriteLine("Write sum in cents or kopecs");
                string sum = Console.ReadLine();
                decimal val = Convert.ToDecimal(sum);
                decimal converted;
                Converter Con = new Converter(4000, 3900);
                if (valute == "0")
                {
                    converted = Con.GetDollar() * val;
                    Console.WriteLine("Your converted valute in kopecs : " + converted / 100);
                }
                if (valute == "1")
                {
                    converted = Con.GetEuro() * val;
                    Console.WriteLine("Your converted valute in kopecs : " + converted / 100);
                }
                if (valute == "2")
                {
                    converted = val / Con.GetDollar();
                    Console.WriteLine("Your converted valute in cents : " + converted * 100);
                }
                if (valute == "3")
                {
                    converted = val / Con.GetEuro();
                    Console.WriteLine("Your converted valute in cents : " + converted * 100);
                }

            }
            else Console.WriteLine("Eror");
            Console.ReadKey();
        }


    }

}
