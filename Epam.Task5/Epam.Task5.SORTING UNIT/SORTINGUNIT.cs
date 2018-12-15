using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.SORTING_UNIT
{
    public class SORTINGUNIT
    {
        public delegate string SortFinished();
        
        public delegate int Comparison<T>(T first, T second);

        public event SortFinished Already;

        public Thread Th { get; private set; }

        public void Sort<T>(T[] a, Comparison<T> compare)
        {
            if (compare == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (compare(a[i], a[j]) > 0)
                    {
                        var temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            this.Already?.Invoke();
        }

        public int Compareint(int first, int second)
        {
            if (first > second)
            {
                return 1;
            }

            if (first == second)
            {
                return 0;
            }

            return -1;
        }

        public void Sortflow<T>(T[] a, Comparison<T> compare)
        {
            ThreadStart thstart = new ThreadStart(() => this.Sort(a, compare));
            this.Th = new Thread(thstart);
            this.Th.Start();
        }

        public string Conclusion()
        {
            Console.WriteLine("array is ready");
            return "array is ready";
        }
    }
}
