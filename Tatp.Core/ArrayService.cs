using System;
using System.Collections.Generic;

namespace Tatp.Core
{
    public static class ArrayService
    {
        public static List<int> ArrayCreate(int size)
        {
            var rndNumber = new Random();
            var array = new List<int>();
            for (var i = 0; i < size; i++)
                array.Add(rndNumber.Next());
            return array;
        }
    }
}
