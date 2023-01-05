﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    internal class Datalist<T>
    {
         
        private T[] arr;
        public Datalist()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
