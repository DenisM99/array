using System;
using System.Linq;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//что бы считать массив в консоле
            foreach(int el in arr)
            {
                Console.Write(el + " ");
            }
        }
    }
}
