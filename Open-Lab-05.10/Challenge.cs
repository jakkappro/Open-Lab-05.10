using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            String snum = num.ToString();
            int ret = 1;
            Console.WriteLine(Convert.ToInt32(snum[0]));
            for (int i = 0; i < snum.Length; i++)
                ret *= Convert.ToInt32(snum[i]);

            return ret;
        }
    }
}