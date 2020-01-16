using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding
{
    public static class String
    {
        public static int CountDigits(this string value, bool acceptSpecialSymbols)
        {
            int cnt = 0;
            foreach (char symbol in value)
            {
                if (char.IsDigit(symbol))
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
