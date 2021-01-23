using System;

namespace DictionaryCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ankara");
            myDictionary.Add(2, "İstanbul");
            myDictionary.Add(3, "İzmir");

            Console.WriteLine(myDictionary.Get(2));

            Console.ReadLine();
        }
    }
}
