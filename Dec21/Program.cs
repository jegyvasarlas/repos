using System;
using System.Collections.Generic;
using System.Linq;

namespace Dec21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int tmp = rnd.Next(3, 6);
            int num = 0;
            int ivoId = 1;
            HashSet<int> nums = new HashSet<int>();
            while (num < tmp)
            {
                nums.Add(rnd.Next(1, 21));
                num++;
            }
            for(int i = 0 ; i < nums.Count ; i++)
            {
                Console.WriteLine($"INSERT INTO jar(iid, kid) VALUES ({ivoId},{nums.ElementAt(i)});");
            }
            nums.Clear();
            while (ivoId!=11)
            {
                tmp = rnd.Next(3, 6);
                num = 0;
                while (num < tmp)
                {
                    nums.Add(rnd.Next(1, 21));
                    num++;
                }
                for (int i = 0; i < nums.Count; i++)
                {
                    Console.WriteLine($"INSERT INTO jar(iid, kid) VALUES ({ivoId},{nums.ElementAt(i)});");
                }
                nums.Clear();
                ivoId++;
            }
        }
    }
}