using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitClass
{
    class CustomClass<T> 
    {


        public T[] objects = new T[0];
        public int size { get; private set; }


        public void Add(T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size + 1];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = objects[i];
                }
                tempArray[size] = value;
                size++;
                objects = tempArray;
            }
        }
    }
}
