using DSandAlgoProg.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg
{
    class BalanceParanthesis
    {
        public static void Balance()
        {
            string text = File.ReadAllText(@"E:\DS-Algo01\DSandAlgorithms01\DSandAlgoProg\Utility\Airthmatic.txt");
            string[] textArry = text.Split();
            CustomStack<string> cs = new CustomStack<string>();
            foreach (var result in textArry)
            {
                if (result == "(")
                {
                    cs.Push("(");
                }
                else
                {
                    cs.Pop(")");
                }
                if (cs.Isempty())
                {
                    Console.WriteLine("Balaenced Parathensis");
                }
                else
                {
                    Console.WriteLine("Not a Balanced Parathensis");
                }
            }
        }
    }
}
