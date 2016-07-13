using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        Console.Error.WriteLine(temps);
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if(string.IsNullOrWhiteSpace(temps))
        {
            Console.WriteLine(0);
            return;
        }
        

        int[] values = new int[n];
        
        string[] tmps = temps.Split(' ');
        for(int i = 0; i < n; i++)
            int.TryParse(tmps[i], out values[i]);

        if(values.All(x => x < 0))
        {
            Console.WriteLine(values.Max());
            return;
        }
        
        var v = values.Where(x => x > 0).OrderBy(x => x).First();
        Console.WriteLine(v);
    }
}
