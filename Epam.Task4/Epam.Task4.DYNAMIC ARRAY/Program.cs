using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DYNAMIC_ARRAY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("create an instance of DYNAMICARRAY with a size of 1");
            DYNAMICARRAY<object> array = new DYNAMICARRAY<object>(1);
            Console.WriteLine("test \"add\" add objects of different types larger than the size of the array");
            array.Add("somestring");
            array.Add(15);
            array.Add(true);
            Console.WriteLine(array.Remove(2));
            Console.WriteLine(array.Remove(1));
            Console.WriteLine(array.Insert(0, "newstring"));
            Console.WriteLine(array.Insert(5, 44444));
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Capacity);
            var testindexer = array.Indexer(4);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            DYNAMICARRAY<object> array1 = new DYNAMICARRAY<object>(array);

            array.AddRange(array1);
            int sdfsd = 5;

        }
    }
}
