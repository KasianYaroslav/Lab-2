using System;

namespace Ex3
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("One");
            myList.Add("Two");
            myList.Add("Three");
            myList.Add("Four");
            myList.Add("Five");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            
            Console.WriteLine(new string('-',30));

            var array = myList.GetArray();

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < result.Length; i++)
                result[i] = list[i];
            return result;
        }
    }
}
