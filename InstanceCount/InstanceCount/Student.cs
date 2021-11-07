using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceCount
{
    class Student
    {
        private static int instanceCount = 0;

        public Student()
        {
            instanceCount++;
        }

        public static int ShowInstanceCount()
        {
            return instanceCount;
        }
    }
}
