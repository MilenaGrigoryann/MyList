using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            _List list1 = new _List();
            _List list2 = new _List();
            list1.Add(1);
            list1.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list1.AddRange(list2);
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
            list1.Reverse();
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list1.Contains(5));
            Console.WriteLine(list1.LastIndexOf(8));
            list1.Remove(7);
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
            int[] arr = list1.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            list1.Clear();
            Console.WriteLine(list1.Count);
        }
    }
}
