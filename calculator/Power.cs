using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Power
    {
        
        public static int GetPower(int baseNumner, int power)
        {
            int result = 1;

            for(int i=0; i<power; i++)
            {

                result = result * baseNumner;

            }
            return result;



        }



    }
}
