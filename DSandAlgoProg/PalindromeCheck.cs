using DSandAlgoProg.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg
{
    class PalindromeCheck
    {
        public static void IsPalindrome()
        {
            CustomLinkedList<char> linkedList = new CustomLinkedList<char>();
            Console.WriteLine("Enter a String to Check Palindrome");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            linkedList.Display();
            string reverseWord = linkedList.DequeuePalindromeChecker();
            if (input == reverseWord)
            {
                Console.WriteLine("{0} is a Palindrome!", input);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome!", input);
            }
        }
    }
}
