using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> data = new MyDictionary<int, string>();
            data.Add(1, "Mushvig");
            data.Add(589, "Guluzada");

            data.GetData();

        }
    }
}
