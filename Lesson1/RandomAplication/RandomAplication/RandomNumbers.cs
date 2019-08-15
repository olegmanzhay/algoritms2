using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAplication
{
    public class RandomNumbers
    {
        int number;

        public int RandomNumber1(RandomNumbers A)
        {
            Random rnd = new Random();
            A.number = rnd.Next(0, 101);
            return A.number;
        }
        public int RandomNumber2(RandomNumbers A)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            int time = 0;
            time = date1.Millisecond/10;
            return time;
        }
    }
}
