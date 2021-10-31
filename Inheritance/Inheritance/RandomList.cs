using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    class RandomList<T> : List<T>
    {
        public int RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, Count);
            RemoveAt(index);
            return index;
        }

    }
}
//private Random random;

//public RandomList()
//{
//    random = new Random();
//}

//public T GetRandomElement()
//{
//    var index = random.Next(0, Count);
//    return this[index];
//}

//public void RemoveRandomElement()
//{
//    var index = random.Next(0, Count);
//    RemoveAt(index);
//}
