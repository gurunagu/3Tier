using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Layer;

namespace Bussiness_layer
{
    public class BussinessLayer
    {
        public void merge(double var)
        {
            DataLayer.s = DataLayer.s + " " + var;  
        }
        public string display()
        {
            return DataLayer.s;
        }
    }
}
