/* Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class 
    
    Program
    {
        static void Main(string[] args)
        {
            string line = null;

            //--- ввод размера массива ---

            int value_mass = 0;
            while (value_mass < 1)
            {
                Console.WriteLine("Введите размер массива");
                line = Console.ReadLine();

                try
                {
                    value_mass = int.Parse(line);
                    if (value_mass <= 0) value_mass = 0;
                }
                catch
                {
                    value_mass = 0;
                }

                if(value_mass == 0) Console.WriteLine("Размер массива зада неверно");
                else Console.WriteLine("Размер массива " + value_mass);
            }

            //--- ввод элементов массива ---

            List<int> numbers = new List<int> { };
            int i = 1;
            int elem_mass = 0;
            while (value_mass > 0)
            {
                Console.WriteLine("Введите элемент массива № " + i);
                line = Console.ReadLine();

                try
                {
                    elem_mass = int.Parse(line);
                    if(elem_mass < 1 || elem_mass > 100)
                    {
                        Console.WriteLine("Элемент массива задан неверно");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Элемент массива задан неверно");
                    continue;
                }

                numbers.Add(elem_mass);

                i++;
                value_mass--;
            }

            //---

            Console.WriteLine();
            Console.WriteLine(i-1 + " ->  [{0}]", String.Join(",", numbers));

            Console.ReadLine();
        }
    }
}
