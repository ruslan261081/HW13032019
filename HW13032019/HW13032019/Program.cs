using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13032019
{
    class Program
    {
        static void Main(string[] args)
        {

            MyProtecdetUniqueList list = new MyProtecdetUniqueList("12345");

            list.Add("hello");

            list.Add("C#");

            list.Add(".NET");

            try

            {

                list.Remove("Java");

            }

            catch (InvalidOperationException e)

            {

                Console.WriteLine(e);

            }

            catch (Exception e)

            {

                Console.WriteLine("Unknown " + e);



            }

            finally

            {

                Console.WriteLine("Finally here!");

            }



            Console.WriteLine(list);



            MyProtectedUniqueListGeneric<int> listNumbers = new MyProtectedUniqueListGeneric<int>("12345");

            listNumbers.Add(1);

            listNumbers.Add(2);

            listNumbers.Add(3);

            try

            {

                listNumbers.Add(1);

            }

            catch (InvalidOperationException e)

            {

                Console.WriteLine(e);

            }

            catch (Exception e)

            {

                Console.WriteLine("Unknown " + e);



            }



            Console.WriteLine(listNumbers);
        }
    }
}
