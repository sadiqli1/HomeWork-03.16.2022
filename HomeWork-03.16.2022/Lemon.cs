using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_03._16._2022
{
    class Lemon
    {
        public char Vitamin;
        public Lemon(char vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return Vitamin.ToString(); 
        }
    }
}
