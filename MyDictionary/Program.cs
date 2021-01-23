using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryClass<int, string> dictionaryClass = new DictionaryClass<int, string>();
            dictionaryClass.Add(4500, "hp notebook");
            dictionaryClass.Add(5600, "huawei notebook");

            Console.WriteLine(dictionaryClass.Count);
            
    }

    }
}