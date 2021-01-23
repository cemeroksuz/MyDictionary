using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();

            cities.Add(1, "Adana");
            cities.Add(2, "Adıyaman");
            cities.Add(3, "Afyon");
            

            for (int i = 0; i < cities.keys.Length; i++)
            {
                Console.WriteLine(cities.keys[i] + "->" + cities.values[i]);
            }
        }
    }
}
