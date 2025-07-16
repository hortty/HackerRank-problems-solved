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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int posValues = 0;
        int negValues = 0;
        int zeroValues = 0;
        
        foreach(var number in arr)
        {
            if(number > 0)
            {
                posValues++;
            }
            else if(number < 0)
            {
                negValues++;
            }
            else 
            {
                zeroValues++;
            }
        }
        
        if(arr.Count == 0)
        {
            Console.WriteLine(0);
            Console.WriteLine(0);
            Console.WriteLine(0);    
            return;
        }
        
        Console.WriteLine(posValues/(arr.Count*1.0));
        Console.WriteLine(negValues/(arr.Count*1.0));
        Console.WriteLine(zeroValues/(arr.Count*1.0));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
