using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Fat
    {
        
        public static double fat(double num)
        {
            if (num <= 1)
                return 1;
            else return num * fat(num - 1);
        }

        internal static int fat(object p)
        {
            throw new NotImplementedException();
        }
    }
}
