using System;
using System.Collections.Generic;

namespace HomeWork_03._16._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple('A');
            Pineapple pineapple = new Pineapple('C');
            Lemon lemon = new Lemon('E');
            BasketList basketList = new BasketList();
            basketList.Add(apple);
            basketList.Add(pineapple);
            basketList.Add(lemon);
            foreach (var item in basketList.GetArr())
            {
                Console.WriteLine(item);
            }

            #region Task2
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("C#", "01.14.2002");
            //dic.Add("Java", "01.14.1996");
            //dic.Add("C++", "01.14.1987");
            //dic.Add("C", "01.14.1998");
            //Console.WriteLine("Name:");
            //foreach (string item in dic.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Date of creation:");
            //foreach (string item in dic.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
