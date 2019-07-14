using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass<int> customList = new CustomClass<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Remove(1);


          
        }



    }
}
