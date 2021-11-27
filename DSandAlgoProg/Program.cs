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
            Console.WriteLine("Welcome to Data Structure Programs Press\n 1-BankingCashCounter\n 2- Ordered List\n 3-Unordered List 4-Exit\n");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    BankingCashCounter bank = new BankingCashCounter();
                    bank.Counter();
                    break;
                case 2:
                    Console.WriteLine("Enter the Number you want to Search");
                    int searchNum = Convert.ToInt32(Console.ReadLine());
                    OrderedList.Ordered(searchNum);
                    break;

                case 3:
                    UnorderedList.UnOrdered();
                    break;

                case 4:
                    flag = false;
                    break;
            }
        }
    }
}
