using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;

namespace LeetCode
{
    public class Helper
    {
        public static ListNode CreateList(int[] values)
        {
            if (values.Length == 0)
                return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static void PrintList(ListNode list)
        {
            while (list != null)
            {
                Console.Write(list.val + " ");
                list = list.next;
            }
        }

        public static void PrintListOfLists<T>(IList<IList<T>> list)
        {
            foreach (var l in list)
            {
                foreach (var i in l)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintList(IList<string> list)
        {
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
        }

        public static T[][] ConvertStringInto2DArray<T>(string s)
        {
            s = s.Replace("[[", "").Replace("]]", "").Replace("], [", "],[");

            string[] rows = s.Split(new string[] { "],[" }, StringSplitOptions.None);

            T[][] result = new T[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                string[] cols = rows[i].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                result[i] = new T[cols.Length];

                for (int j = 0; j < cols.Length; j++)
                {
                    result[i][j] = (T)Convert.ChangeType(cols[j], typeof(T));
                }
            }

            return result;

        }
        public static void Print2DArray<T>(T[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }    
}
