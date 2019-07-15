using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitClass
{
    public class CustomClass<T> : IEnumerable<T>
    {

        public T[] objects = new T[0];
        private T[] array;
        private T value;
        int capacity;
        int index;


        public int size { get; private set; }
        public int Count { get; set; }
       
        public CustomClass()
        {
            int capacity = 5;
            T[] objects = new T[capacity];
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }


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


        public void Remove(T value)
        {
            if (objects.Length <= size)
            {

            }
            
                


        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];

            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }



        public override string ToString()
        {
            string value = "";
            for (int i = 0; i < size; i++)
            {
                value = objects[i].ToString();
            }
            return value;
        }




        public CustomClass<T> Zip(CustomClass<T> listA, CustomClass<T> listB)
        {
            CustomClass<T> list = new CustomClass<T>();
            for (int i = 0; i < size; i++)
            {
                list.Add(listA.objects[i]);
                list.Add(listB.objects[i]);
            }
            return list;
        }



      

        public static CustomClass<T> operator +(CustomClass<T> listA, CustomClass<T> listB)
        {
            CustomClass<T> list = new CustomClass<T>();
            foreach (T item in listA)
            {
                list.Add(item);
            }
            foreach (T item in listB)
            {
                list.Add(item);
            }
            return list;
        }

        public static CustomClass<T> operator -(CustomClass<T> listA, CustomClass<T> listB)
        {
            CustomClass<T> list = new CustomClass<T>();
            foreach (T item in listA)
            {
                list.Remove(item);
            }
            foreach (T item in listB)
            {
                list.Remove(item);
            }
            return list;







        }
}   }
