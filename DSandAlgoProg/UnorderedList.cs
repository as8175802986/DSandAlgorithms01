using DSandAlgoProg.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg
{
    class UnorderedList
    {
        public static void UnOrdered()
        {
            string text = File.ReadAllText(@"C:\Users\DELL\source\Repos\DSandAlgoProg\Utility\WordFile.txt");
            string[] textArray = text.Split();
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.Display();
            Console.WriteLine("Enter the String Which You Want to Search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\DELL\source\Repos\DSandAlgoProg\Utility\WordFile.txt", textFile);
            list.Display();
        }
    }
}
