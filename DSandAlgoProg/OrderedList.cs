using DSandAlgoProg.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg
{
    class OrderedList
    {
        public static void Ordered(int searchNum)
        {
            string text = File.ReadAllText(@"C:\Users\DELL\source\Repos\DSandAlgoProg\Utility\NumberList.txt");
            string[] textArry = text.Split();
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            int[] arr = new int[textArry.Length];
            for (int i = 0; i < textArry.Length; i++)
            {
                int a = Convert.ToInt32(textArry[i]);
                arr[i] = a;
            }
            Array.Sort(arr);
            list.Display();

            if (list.Search(searchNum))
            {
                list.DeleteElement(searchNum);
            }
            else
            {
                list.Sort(searchNum);
            }
            string textFile = list.ReturnString();
            File.ReadAllText(@"C:\Users\DELL\source\Repos\DSandAlgoProg\Utility\NumberList.txt");
            list.Display();
        }
    }
}
