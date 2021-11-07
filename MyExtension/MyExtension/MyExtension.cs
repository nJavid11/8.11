using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtension
{
    static class MyExtension
    {
        public static int MyKok(this int eded)
        {
            int i;
            int a;
            for (i = 0; i < eded; i++)
            {
                a = i * i * i;

                if (a == eded)
                {
                    break;
                }
                else if (a > eded)
                {
                    return -1;
                }

            }

            return i;
        }
    }
}
