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
        int i;
        var strs = new List<int>();
        
        int N = int.Parse(Console.ReadLine());
        for (i = 0; i < N; i++)
        {
            strs.Add(int.Parse(Console.ReadLine()));
        }

        var strengths = strs.OrderBy(x => x).ToArray();
        var min = strengths[1] - strengths[0];
    
        for(i = 2 ; i < N; i++ )
        {
            var diff =  strengths[i] - strengths[ i - 1];
            if(diff < min) min  = diff;
        }
    
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(min);
    }
}
