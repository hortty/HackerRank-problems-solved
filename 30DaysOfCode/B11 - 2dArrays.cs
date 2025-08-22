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
    public static int CountHourGlasses(List<List<int>> arr)
    {
        int maxTotal = -2000;
        int aux = 0;
        
        for (int i = 0; i < arr.Count() - 2; i++)
        {
            for (int j = 0; j < arr[i].Count() - 2; j++)
            {
                aux = 0;

                aux += arr[i][j];
                aux += arr[i][j+1];
                aux += arr[i][j+2];
                aux += arr[i+1][j+1];
                aux += arr[i+2][j];
                aux += arr[i+2][j+1];
                aux += arr[i+2][j+2];

                if (maxTotal < aux)
                    maxTotal = aux;
            }
        }

        return maxTotal;
    }
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        Console.WriteLine(CountHourGlasses(arr));
    }
}
