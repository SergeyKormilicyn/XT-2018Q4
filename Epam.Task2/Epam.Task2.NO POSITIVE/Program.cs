using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[3,3,3];
            Random ran = new Random();
            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1)+1; j++)
                {
                    for (int z = 0; z < array.GetUpperBound(2)+1; z++)
                    {
                        array[i,j,z] = ran.Next(-100, 100);
                        Console.Write($"array element before conversion = {array[i, j, z]} ");
                        if (array[i, j, z] > 0)
                        {
                            array[i, j, z] = 0;
                        }
                        Console.WriteLine($" after = {array[i, j, z]}");
                    }
                }
            }
        }
    }
}
