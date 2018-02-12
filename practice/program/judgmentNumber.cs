using System;
using System.Collections.Generic;
using System.Linq;

namespace practice.program
{
    public class JudgmentNumber
    {
        private Dictionary<Predicate<int>, int> MyDic = new Dictionary<Predicate<int>, int>
        {
            {(i => i>0 && i<=1), 1},
            {(i => i>1 && i<=3), 2},
            {(i => i>3 && i<=5), 3},
            {(i => i>5 && i<=24), 4},
            {(i => i>24), 5}
        };

        public int ChangeNumber(int num)
        {
            var arr = new[] { 0, 1, 3, 5, 24 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (num > arr[i] && num <= arr[i + 1])
                {
                    return i + 1;
                }
            }
            return 5;
        }

        public int ChangeNumber_2(int num)
        {
            foreach (KeyValuePair<Predicate<int>, int> item in MyDic)
            {
                if (item.Key.Invoke(num))
                {
                    return item.Value;
                }
            }
            return 5;
        }

        public int ChangeNumber_3(int num)
        {
            //return MyDic[MyDic.Keys.Where(m => m.Invoke(num)).First()];
            return MyDic.FirstOrDefault(m => m.Key(num)).Value;
        }

        public bool testPredicate()
        {
            Predicate p = new Predicate((i => i >= 0 && i < 1));
            return p.Invoke(0);
        }

        public delegate bool Predicate(int target);
    }
}