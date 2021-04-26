using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, bool> myDictionary = new MyDictionary<string, bool>();
            myDictionary.Add("First",true);
            myDictionary.Add("Second",true);
            myDictionary.Add("Third",false);
            myDictionary.Add("Can divide by zero",false);
            myDictionary.Add("?", false);
            
            myDictionary["First"] = false;
            foreach (var i in myDictionary.Keys)
            {
                Console.WriteLine(myDictionary[i]);
            }
            Console.WriteLine($"\nCount: {myDictionary.Count}");
        }
    }
}
