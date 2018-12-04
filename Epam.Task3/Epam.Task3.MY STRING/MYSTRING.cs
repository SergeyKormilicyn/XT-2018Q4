using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MY_STRING
{
    public class MYSTRING
    {
        private char[] chr;

        public MYSTRING(string str)
        {
            this.chr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                this.chr[i] = str[i];
            }
        }

        public bool Mycompare(string str)
        {
            if (this.chr.Length == str.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (this.chr[i] != str[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Myconcat(string str)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                sb.Append(this.chr[i]);
            }

            sb.Append(str);
            return sb.ToString();
        }

        public int Myindexof(char chr)
        {
            for (int i = 0; i < this.chr.Length; i++)
            {
                if (this.chr[i] == chr)
                {
                    return i;
                }
            }

            return -1;
        }

        public int Mylastindexof(char chr)
        {
            for (int i = this.chr.Length - 1; i >= 0; i--)
            {
                if (this.chr[i] == chr)
                {
                    return i;
                }
            }

            return -1;
        }

        public string Myremove(int index)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (i != index)
                {
                    sb.Append(this.chr[i]);
                }
            }

            return sb.ToString();
        }

        public string Myremove(int firstindex, int lastindex)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (i < firstindex | i >= lastindex)
                {
                    sb.Append(this.chr[i]);
                }
            }

            return sb.ToString();
        }

        public string[] Mysplit(char chr)
        {
            string[] array;
            int index = 0;
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (this.chr[i] == chr)
                {
                    index++;
                }
            }

            array = new string[index + 1];
            index = 0;

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (this.chr[i] != chr)
                {
                    sb.Append(this.chr[i]);
                }
                else
                {
                    array[index] = sb.ToString();
                    sb.Remove(0, sb.Length);
                    index++;
                }
            }

            array[index] = sb.ToString();
            return array;
        }

        public string Mytrim()
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (!(this.chr[i] == ' ' & i == 0) & !(this.chr[i] == ' ' & i == this.chr.Length - 1))
                {
                    sb.Append(this.chr[i]);
                }
            }

            return sb.ToString();
        }

        public string Mytrim(char one, char two)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (!(((this.chr[i] == one) | (this.chr[i] == two)) & ((i == 0) | (i == this.chr.Length - 1))))
                {
                    sb.Append(this.chr[i]);
                }
            }

            return sb.ToString();
        }

        public string Mysubstring(int index)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                if (i >= index)
                {
                    sb.Append(this.chr[i]);
                }
            }

            return sb.ToString();
        }

        public string Myinsert(int index, string str)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < this.chr.Length; i++)
            {
                sb.Append(this.chr[i]);
                if (i == index - 1)
                {
                    sb.Append(str);
                }
            }

            return sb.ToString();
        }
    }
}
