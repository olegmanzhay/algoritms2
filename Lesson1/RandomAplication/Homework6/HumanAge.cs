using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class HumanAge
    {
        int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        /// <summary>
        /// Возвращает правиьное написание возраста
        /// </summary>
        /// <param name="A">Возраст</param>
        /// <returns></returns>
        public string AgeString(HumanAge A)
        {
            string result = string.Empty;
            if(A.Age % 10 == 1 && A.Age != 11)
            {
                result = $"{A.Age.ToString()} год";
            }
            else if((A.Age % 10 == 2 || A.Age % 10 == 3 || A.Age % 10 == 4) &&  (A.Age != 12 && A.Age != 13 && A.Age != 14))
            {
                result = $"{A.Age.ToString()} года";
            }
            else
            {
                result = $"{A.Age.ToString()} лет";
            }
            return result;
        }
    }
}
