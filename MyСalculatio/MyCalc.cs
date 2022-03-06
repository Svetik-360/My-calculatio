using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyСalculatio
{
    public class MyCalc
    {
        public int F(int a, int b, int x, int c)
        {
            if (c < 0 && x != 0)
            {
                return -a * x - c;
            }
            
            if (c > 0 && x == 0)
            {
                return (x - a) / -c;
            }
            else
            {
                return (b * x) / (c - a);
            }

        }
        public int sum(int x, int y)
        {

            return x + y;

        }
      
    }
}
