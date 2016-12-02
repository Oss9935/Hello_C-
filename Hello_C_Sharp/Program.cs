using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Hello_C_Sharp
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Hello C#");
               Console.WriteLine(args.Length);
               Console.WriteLine("Usage : " + args[0] + "!!");
               Console.ReadKey();
          }
     }
}
