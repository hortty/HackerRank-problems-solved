using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static int TransformBinary(int n)
    {
        string binary = string.Empty;
        
        while(n > 1)
        {
            binary += (n%2).ToString();
            n = n/2;
        }

        binary += n.ToString();

        int maxOnes = CountOnesInBinary(binary);
        
        return maxOnes;
    }
    
    public static int CountOnesInBinary(string s)
    {
        int largerSeq = 0;
        int maxSeq = 0;
        foreach(var bin in s)
        {
            if(bin == '1')
                largerSeq++;
            else
            {
                if(largerSeq > maxSeq)
                    maxSeq = largerSeq;
                    
                largerSeq = 0;
            }
        }

        if(largerSeq > maxSeq)
            maxSeq = largerSeq;
            
        return maxSeq;
    }
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(TransformBinary(n));
    }
}
