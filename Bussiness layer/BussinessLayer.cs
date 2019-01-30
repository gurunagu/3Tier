using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Layer;

namespace Bussiness_layer
{
    public class BussinessLayer
    {
        public void StoreData(double data)
        {
            DataLayer.StoreUserData = DataLayer.StoreUserData + " " + data;  
        }
        public string DisplayData()
        {
            return DataLayer.StoreUserData;
        }
        public bool search(double Value)
        {
            bool checkValue = DataLayer.StoreUserData.Contains(Value.ToString());
            return checkValue;
        }
        public void UserControl()
        {
            int option = 0;
            double data,value;
            while (option != 4)
            {
                Console.WriteLine("\nenter option\n1)Enter Data\n2)Display Stored Data\n3)Search Data\n4)Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("enter data to store");
                            data = double.Parse(Console.ReadLine());
                            this.StoreData(data);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("The data stored in memory is:" + this.DisplayData());
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter data to search");
                            value = double.Parse(Console.ReadLine());
                            if(this.search(value))
                            {
                                Console.WriteLine($"'Data {value} is Present in the DataBase'");
                            }
                            else
                            {
                                Console.WriteLine($"'Data {value} is not there in the DataBase'");
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Press ENTER to exit...");
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
        }
    }
}
