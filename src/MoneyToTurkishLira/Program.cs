using System;
using System.Text;

namespace MoneyToTurkishLira
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //decimal tutar = 765 421 365 789 385;
            decimal[] tutar = new[] {12314123.5m ,642134213.05m,2135497m,56763234, 214.85m };

            foreach (var item in tutar)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(item.ToCurrencyText());
            }

            Console.ReadLine();
        }

       

    }
}
