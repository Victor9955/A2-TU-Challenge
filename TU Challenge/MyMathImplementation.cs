using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            List<int> list = toSort;

            while ()
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (isInOrder(list[i], list[i + 1]) == 1)
                    {
                        int cash = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = cash;
                    }
                }
            }
            return list;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> list = toSort;
            while (!IsListInOrder(list))
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] >= list[i + 1])
                    {
                        int cash = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = cash;
                    }
                }
            }
            return list;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 0; i <= a; i++)
            {
                if(IsPrimary(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);
        }

        public static bool IsEven(int a)
        {
            return(a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if(a == b) return 0;
            if(a < b) return 1;
            else return -1;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count -2; i++)
            {
                if (list[i] >= list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0) throw new ArgumentException();
            if (age >= 150) throw new ArgumentException();
            return age >= 18; 
        }

        public static bool IsPrimary(int el)
        {
            if (el == 2 || el == 3)
                return true;

            if (el <= 1 || el % 2 == 0 || el % 3 == 0)
                return false;

            for (int i = 5; i * i <= el; i += 6)
            {
                if (el % i == 0 || el % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static int Power(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c *= a;
            }
            return c;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            if (a == b) return 0;
            if (a > b) return 1;
            else return -1;
        }
    }
}
