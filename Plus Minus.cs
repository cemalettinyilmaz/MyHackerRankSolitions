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
        double uzunluk=arr.Count();
        double positiveCount=0;
        double negativeCount=0;
        double zeroCount=0;
        
        foreach(var item in arr)
        {
            if(item<0)
            {
               negativeCount++;
            }
            
            else if(item>0) 
            {
             positiveCount++;
            }
            
              
            else
            {
               zeroCount++; 
            }
        }
       double positive=positiveCount/uzunluk;
       double negative=negativeCount/uzunluk;
       double zero=zeroCount/uzunluk;
      Console.WriteLine((double)positive);
       Console.WriteLine((double)negative);
        Console.WriteLine((double)zero);

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
