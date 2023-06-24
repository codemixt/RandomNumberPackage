using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberPackage
{
    public class RandomNumber
    {
        public static int GetNumber(int length)
        {
            if (length > 0)
            {

                if (length > 9)
                {
                    length = 9;
                }

                var MaxValue = "";
                for (int i = 0; i < length; i++)
                {
                    MaxValue += "9";
                }

                Random random = new Random();
                return random.Next(0, Convert.ToInt32(MaxValue));
            }

            return 0;
        }
    }
}
