using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] m = new Milk[0];
            while (true)
            {
                Console.WriteLine("Do you want to add a new milk?(y/n)");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    Console.Write("Please enter the name of milk : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the price : ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the fatrate : ");
                    double fatRate = Convert.ToDouble(Console.ReadLine());

                    Milk m1 = new Milk(name, price, fatRate);
                    Array.Resize(ref m, m.Length + 1);
                    m[m.Length - 1] = m1;
                }
                else if (ans == "n")
                {
                    break;
                }

            }
            foreach (var item in m)
            {
                Console.WriteLine("********************");
                Console.WriteLine("Name - " + item.Name);
                Console.WriteLine("Price - " + item.Price);
                Console.WriteLine("Fatrate - " + item.FatRate);
            }

        }
    }
}
