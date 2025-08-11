using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    private static string even = string.Empty;
    private static string odd = string.Empty;
    
    public static void iterate(int qtde)
    {
        string temp = string.Empty;
        for(int i=0;i<qtde;i++)
        {
            even = string.Empty;
            odd = string.Empty;
            temp = Console.ReadLine();
            
            for(int j=0;j<temp.Length;j++)
            {
                if(j%2==0)
                {
                    even += temp[j];
                }
                else
                {
                    odd += temp[j];
                }
            }
            
            Console.WriteLine($"{even} {odd}");
        }
    }
    
    static void Main(String[] args) {
        int qtde = 0;
        int.TryParse(Console.ReadLine()?.Trim(), out qtde);
        
        iterate(qtde);
    }
}