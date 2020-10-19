using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frogy
{
  public  class StartUp
    {
     public   static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake lake = new Lake(stones);
            List<int> path = new List<int>();

            foreach (var stone in lake)
            {
                path.Add(stone);
            }
            Console.WriteLine( string.Join(", ", path));
        }
    }
}
