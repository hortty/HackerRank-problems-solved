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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var isPMAM = s.Substring(s.Length - 2);
        s = s.Remove(s.Length - 2);
        int initialNum = int.Parse(s.Substring(0, 2)); 
        
        if(isPMAM == "AM")
        {
            if(initialNum == 12)
                initialNum = 0;
                
        }
        else
        {
            if(initialNum != 12)
            {
                initialNum += 12;
            }
        }
        
        string valueParsed = "00";
        
        if(initialNum != 0)
            valueParsed = initialNum.ToString();
            
        if(valueParsed.Length == 1)
            valueParsed = $"0{valueParsed}";
            
        valueParsed += s.Substring(2);
        
        return valueParsed;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
