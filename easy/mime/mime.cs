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
        var map = new Dictionary<string, string>();
        
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            map.Add(EXT.ToUpperInvariant(), MT);
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            var ext = Path.GetExtension(FNAME.ToUpperInvariant());
            if(!string.IsNullOrWhiteSpace(ext)) ext = ext.Substring(1);
            
            string mime;
            string output = map.TryGetValue(ext, out mime) ? mime : "UNKNOWN";
            Console.WriteLine(output);
        }
    }
}
