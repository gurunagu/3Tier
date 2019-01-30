using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussiness_layer;

namespace user_interface
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            BussinessLayer obj = new BussinessLayer();
            int i=0;
            double var;
            while (i != 3)
            {
                Console.WriteLine("\nenter option\n1)Enter Data\n2)Display Stored Data\n3)Exit");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("enter data to store");
                            var = double.Parse(Console.ReadLine());
                            obj.merge(var);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("The data stored in memory is:"+ obj.display());
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Press ENTER to exit...");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid!! Press ENTER toTry again...");
                            Console.ReadLine();
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
