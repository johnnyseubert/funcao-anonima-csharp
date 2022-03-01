using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();
            
            lista.Add(new Product("Tv", 900.00));
            lista.Add(new Product("Notebook", 1200.00));
            lista.Add(new Product("Tablet", 450.00));
            
            lista.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}