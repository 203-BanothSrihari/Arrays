using System;
using System.Collections;  //collection is used to collect all the elements which is int, string, double and integer 

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("srihari");
            arraylist.Add(3);
            arraylist.Add(4.6);

            //access individul item using indexer
            int firstElement = (int)arraylist[0]; //return 1
            string secondElement = (string)arraylist[1]; //returns "srihari"
            int thirdElement = (int)arraylist[2];  //returns 3
            double fourthElement = (double)arraylist[3];  //returns 4.6

            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);
            Console.WriteLine(thirdElement);
            Console.WriteLine(fourthElement);

        }
    }
}
