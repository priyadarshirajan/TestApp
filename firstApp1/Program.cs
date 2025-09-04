using firstApp1.Service;
using System;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace firstApp1
{
    public class Program
    {
        static async Task Main(string[] args)
        {




            var res = LeetCodeEasyProblems.IsPalindrome();

            //var t = new AdoNetService();
            //t.Execute();

            Console.ReadKey();
        }
    }
}