using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13032019
{
    class MyProtectedUniqueListGeneric<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> words;

        private string password;



        public MyProtectedUniqueListGeneric(string password)

        {

            words = new List<T>();

            this.password = password;

        }



        public void Add(T item)

        {

            if (item == null)

            {

                throw new ArgumentNullException("string is empty/null");

            }



            if (words.Contains(item))

                throw new InvalidOperationException($"{item} already exists!");



            words.Add(item);

        }

        public void Remove(T item)

        {

            if (item == null)

            {

                throw new ArgumentNullException("string is empty/null");

            }



            if (!words.Contains(item))

                throw new InvalidOperationException($"{item} does not exist!");



            words.Remove(item);

        }



        public void RemoveAt(int index)

        {

            if (index < 0)

            {

                throw new IndexOutOfRangeException

                    ($"{index} cannot be negative! dah");

            }



            if (index >= words.Count)

            {

                throw new IndexOutOfRangeException

                    ($"{index} is bigger than list size {words.Count}");

            }



            words.RemoveAt(index);

        }



        public void Clear(string password)

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



        public void Sort(string password)

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

            string result = $"List values {words.Count} ";



            foreach (T s in words)

            {

                result += $"\n{s}";

            }



            return result;

        }



        public IEnumerator<T> GetEnumerator()

        {

            return words.GetEnumerator();

        }



        IEnumerator IEnumerable.GetEnumerator()

        {

            return words.GetEnumerator();

        }

       
    }
}
