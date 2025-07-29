using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int integer = 0;
        double floatNumber = 0;
        string text = string.Empty;
        
        // Read and save an integer, double, and String to your variables.
        integer = int.Parse(Console.ReadLine() ?? string.Empty);
        floatNumber = double.Parse(Console.ReadLine() ?? string.Empty);
        text = Console.ReadLine() ?? string.Empty;
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(integer+i);
        
        // Print the sum of the double variables on a new line.
        floatNumber += d;
        Console.WriteLine((floatNumber.ToString("0.0")));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s+text);
    }
}