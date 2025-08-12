using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine()?.Trim()!);
        Dictionary<string, long> dict = new Dictionary<string, long>();
        string line = string.Empty;
        
        for(int i=0;i<n;i++)
        {
            line = Console.ReadLine()?.Trim();
            dict.Add(line.Split(' ')[0], long.Parse(line.Split(' ')[1]));
        }
        
        while(true)
        {
            line = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(line))
                break;
                
            if(dict.ContainsKey(line))
            {
                Console.WriteLine($"{line}={dict[line]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        
    }
}