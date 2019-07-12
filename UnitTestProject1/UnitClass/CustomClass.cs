using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitClass
{
    public class CustomClass<T>
    {
        public T[] objects = new T[0];
        private T value;

        public int size { get; private set; }
        public int Count { get; set; }


        public void Add(int v)
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


        public void Remove(int v)
        {

        }

                







}   }
