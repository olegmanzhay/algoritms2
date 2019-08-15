using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Number
    {
        int number;

        public int MyNumber
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
        /// <summary>
        /// Возвращает ложь, если все цифры четные и наоборот
        /// </summary>
        /// <param name="A">Введенное число пользователем</param>
        /// <returns></returns>
        public bool TrueOrFalse(Number A)
        {
                int i = 0;
                while (A.number != 0)
                {
                    if (A.number % 2 != 0)
                    {
                        i++;
                    }
                    A.number /= 10;
                }
                if (i > 0)
                    return true;
                else
                    return false;
        }
    }
}
