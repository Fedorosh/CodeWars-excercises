using System;
using System.Collections.Generic;
using System.Text;

namespace Code_wars
{
    public enum Yolecki
    {
        marek = 0,
        robert = 7,
        kasia = 12,
        czesza = 13,
        maciek = 16
    }
    class Number
    {
        public int DigitalRoot(long n)
        {
            // Your awesome code here!

            if (n % 10 == n) return (int)n;

            //STRING ISSUE

            string en = n.ToString();
            int sum = 0;

            foreach (char v in en)
            {
                sum += v - '0';
            }

            n = sum;


            //MATH ISSUE

            //long temp = n;
            //int count = 0;
            //int sum = 0;
            //while (temp > 0)
            //{
            //    temp /= 10;
            //    count++;
            //}
            //temp = 1;
            //while (count > 1)
            //{
            //    temp *= 10;
            //    count--;
            //}
            //while (temp > 0)
            //{ 
            //    count = (int)(n / temp);
            //    sum += count;
            //    n -= temp * count;
            //    temp /= 10;
            //}
            //n = sum;


            return DigitalRoot(n);
        }
        public int DescendingOrder(int num)
        {
            if (num < 0) return 0;
            string reverse = num.ToString();
            List<char> lista = new List<char>();
            foreach(char v in reverse)
            {
                lista.Add(v);
            }
            lista.Sort();
            lista.Reverse();
            reverse = string.Join("", lista.ToArray());

            return Int32.Parse(reverse);
        }
        public bool IsValidWalk(string[] walk)
        {
            //insert brilliant code here
            if (walk.Length != 10) return false;
            int westEast = 0;
            int northSouth = 0;
            foreach (var x in walk)
            {
                switch (x)
                {
                    case "n":
                        northSouth++;
                        break;
                    case "s":
                        northSouth--;
                        break;
                    case "e":
                        westEast++;
                        break;
                    case "w":
                        westEast--;
                        break;
                }
            }
            return westEast == 0 && northSouth == 0;
        }
        public int find_it(int[] seq)
        {
            int temp;
            int count_temp = 0;
            foreach(var i in seq)
            {
                temp = i;
                foreach(var x in seq)
                {
                    if (temp == x) count_temp++;
                }
                if (count_temp % 2 != 0) return temp;
            }
            return -1;
        }
        public bool ValidParentheses(string input)
        {
            // Your code here
            if (input.Length > 100 || input.Length < 0)
                return false;
            int output = 0;
            foreach (char c in input)
            {
                if (c == '(') output++;
                if (c == ')') output--;
                if (output < 0) return false;
            }
            return output == 0;
           
        }

        public bool AreTheySame(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            Array.Sort(a);
            Array.Sort(b);
            for (int x = 0; x < a.Length; x++)
                if (Math.Pow(a[x], 2) != b[x]) return false;
            return true;
        }
    }
}
