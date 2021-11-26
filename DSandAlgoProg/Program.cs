using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Welcome to Data Structure Programs Press\n 1-BankingCashCounter\n 2-Exit\n");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    BankingCashCounter bank = new BankingCashCounter();
                    bank.Counter();
                    break;
              
                case 2:
                    flag = false;
                    break;
            }
        }
    }
}
