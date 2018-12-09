using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DYNAMIC_ARRAY
{
    public class DYNAMICARRAY<T> : IEnumerable<object>, IEnumerable
    {
        private object[] obj;
        
        public DYNAMICARRAY()
        {
            this.obj = new object[8];
            this.Capacity = this.obj.Length;
        }

        public DYNAMICARRAY(int n)
        {
            this.obj = new object[n];
            this.Capacity = this.obj.Length;
        }

        public DYNAMICARRAY(IEnumerable<T> n)
        {
            this.obj = new object[n.Count()];

            for (int i = 0; i < n.Count(); i++)
            {
                this.obj[i] = n.ElementAt(i);
            }

            this.Capacity = this.obj.Length;
        }

        public int Capacity { get; private set; }

        public int Length { get; private set; }

        public void Add(T obj)
        {
            if (this.Length != this.obj.Length)
            {
                this.obj[this.Length] = obj;
            }
            else
            {
                int length = this.obj.Length;
                object[] objcopy = this.obj;
                this.obj = new object[length * 2];
                this.Capacity = this.obj.Length;

                for (int i = 0; i < objcopy.Length; i++)
                {
                    this.obj[i] = objcopy[i];
                }

                this.obj[this.Length] = obj;
            }

            this.СountLength();
        }

        public void AddRange(IEnumerable<T> n)
        {
            for (int i = this.obj.Length - 1; i > 0; i--)
            {
                if (this.obj[i] != null)
                {
                    object[] objcopy = this.obj;
                    this.obj = new object[i + n.Count() + 1];
                    for (int j = 0; j <= i; j++)
                    {
                        this.obj[j] = objcopy[j];
                    }

                    for (int j = 0; j < n.Count(); j++)
                    {
                        this.obj[i + j + 1] = n.ElementAt(j);
                    }

                    break;
                }
            }
        }

        public bool Remove(int index)
        {
            if (index < this.obj.Length)
            {
                this.obj[index] = default(T);
                this.СountLength();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert(int index, T obj)
        {
            if (index <= this.obj.Length - 1)
            {
                if (this.obj[index] == null)
                {
                    this.obj[index] = obj;
                    this.СountLength();
                    return true;
                }
                else
                {
                    object[] objcopy = this.obj;
                    this.obj = new object[this.obj.Length * 2];
                    this.Capacity = this.obj.Length;
                    int newelement = 0;

                    for (int i = 0; i < objcopy.Length; i++)
                    {
                        if (i != index)
                        {
                            this.obj[i] = objcopy[i - newelement];
                        }
                        else
                        {
                            this.obj[i] = obj;
                            newelement++;
                        }
                    }

                    this.СountLength();
                    return true;
                }
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("argument outside array border");
            }
        }

        public object Indexer(int index)
        {
            if (index <= this.obj.Length)
            {
                return this.obj[index];
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("argument outside array border");
            }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return ((IEnumerable<object>)this.obj).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<object>)this.obj).GetEnumerator();
        }

        private void СountLength()
        {
            int k = 0;

            for (int i = 0; i < this.Capacity; i++)
            {
                if (!(this.obj[i] == null))
                {
                    k++;
                }
            }

            this.Length = k;
        }
    }
}
