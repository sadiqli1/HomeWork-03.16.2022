using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_03._16._2022
{
    class BasketList/*<T>*/
    {
        public char[] arr;

        public BasketList()
        {
            arr = new char[0];
        }

        public void Add(char vitamin)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = vitamin;
        }
        public char[] GetArr()
        {
            return arr;
        }

    }
}
