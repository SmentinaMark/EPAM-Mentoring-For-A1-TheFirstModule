using System;
using System.Collections.Generic;
using MyClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Необходимо ввести данные, как параметр командной строки(cmd)
            try
            {
                GetName getName = new GetName(args[0]);
                Console.WriteLine(getName.GetNameMethod());
                Console.ReadLine();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Необходимо ввести данные через командную строку(" + ex.Message + ")");
            }
        }
    }
}
