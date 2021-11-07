using System;

namespace InstanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Console.WriteLine("Instance count: " + Student.ShowInstanceCount());
        }
    }
}
