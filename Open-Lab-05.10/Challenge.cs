using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            string snum = num.ToString();
            int ret = 1;
            for (int i = 0; i < snum.Length; i++) ret *= int.Parse(snum.ToCharArray()[i].ToString());
            return ret;
        }
    }
}