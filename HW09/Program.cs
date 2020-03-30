﻿using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;

namespace HW09
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"product.csv"))
            {
                List<string> id = new List<string>();
                List<string> name = new List<string>();
                List<string> price = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    id.Add(values[0]);
                    name.Add(values[1]);
                    price.Add(values[2]);

                }
                Console.WriteLine("Products in your cart are");
                Console.WriteLine("none");
                Console.WriteLine("----------");
                Console.WriteLine("Total amount: 0.00 Bath");

                ArrayList item = new ArrayList();
                int sum = 0;
                int count = 1;
                while (count <= 100)
                {
                    Console.WriteLine("Please input a product key:");
                    string inputid = Console.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        if (id[i] == inputid)
                        {
                            string v = price[i];
                            int x = Convert.ToInt32(v);
                            double y = Convert.ToDouble(v);
                            sum = sum + x;
                            item.Add(name[i] + "    " + y);

                        }
                    }
                    Console.WriteLine("Products in your cart are");
                    for (int i = 0; i < item.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + item[i]);
                    }
                    Console.WriteLine("---");
                    Console.WriteLine("Total amount: " + sum + " bath");
                    // Console.WriteLine(array1.Length);
                }
            }
        }
    }
}