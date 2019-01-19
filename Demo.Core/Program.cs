using System;
using System.Linq;
using Snowflake.Net.Core;

namespace Demo.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = new IdWorker(1, 1);
            long id = worker.NextId();
            Console.WriteLine($"ID:{id} , Length:{id.ToString().Length}");
            var list = worker.Next(10);
            list.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
