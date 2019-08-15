
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Numbers
    {
        int number;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string resultNumbers(Numbers A)
        {
            string result = string.Empty;
            int n = A.number.ToString().Length;
            int k = 10;
            for (int i = 0; i <= A.Number; i++)
            {
                if (i % k == 0 && i != 0)
                {
                    k *= 10;
                }
                if (k <= 10 && Math.Pow(i, 2) % 10 * k == i)
                {
                    result += $"{i} ";
                }
                else if (Math.Pow(i, 2) % k == i)
                {
                    result += $"{i} ";
                }
            }
            return result;
        }
    }
}
