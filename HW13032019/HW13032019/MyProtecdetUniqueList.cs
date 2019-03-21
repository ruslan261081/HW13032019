using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13032019
{
    class MyProtecdetUniqueList : IEnumerable<string>
    {
        List<string> words = new List<string>();
        private string password;

        public MyProtecdetUniqueList(string password)
        {
            words = new List<string>();
            this.password = password;
        }
        public void Add(string item)
        {
           if(item == null || item == string.Empty)
           {
                throw new ArgumentException("String is empty/null");
           }

            if (words.Contains(item))
                throw new InvalidOperationException($"{item} alredy exists!");
            words.Add(item);
        }
        public void Remove(string item)
        {
            if (item == null || item == string.Empty)
            {
                throw new ArgumentException("String is empty/null");
            }

            if (!words.Contains(item))
                throw new InvalidOperationException($"{item} does not exist!");
            words.Remove(item);
        }
        public void RemoveAt(int index)
        {
            if(index < 0 )
            {
                throw new IndexOutOfRangeException
                    ($"{index} cannot be negative! dah");
            }
            if(index >= words.Count)
            {
                throw new IndexOutOfRangeException
                    ($"{index} is bigger than list size {words.Count}");
            }

            words.RemoveAt(index);
        }
        public void Clear (string password)
        {
            if (this.password != password)
            {
                throw new
                    AccessViolationException($"{password} is not the correct password. Hacker!!");
            }
            else
            {
                words.Clear();
            }
        }
        public void Sort( string password)
        {
            if (this.password != password)
            {
                throw new
                    AccessViolationException($"{password} is not the correct password. Hacker!!");
            }
            else
            {
                words.Sort();
            }
        }

        public override string ToString()
        {
            string result = $"List values {words.Count}";

            foreach (string s in words)
            {
                result += $"\n{s}";
            }

            return result;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
