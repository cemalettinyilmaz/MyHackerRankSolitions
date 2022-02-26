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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
          int sayacMin = 0;
                int sayacMax=0;

            List<int> Minumum=new List<int>();
            Minumum.Add(scores[0]);
            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < Minumum[i-1])
                {
                    Minumum.Add(scores[i]);
                    sayacMin++;

                }              
               
                else
                    Minumum.Add(Minumum[i-1]);

            }

            List<int> Maksimum = new List<int>();
            Maksimum.Add(scores[0]);
            for (int i =1; i < scores.Count; i++)
            {
                if(scores[i]>Maksimum[i-1])
                {
                    Maksimum.Add(scores[i]);
                    sayacMax++;
                }
                else
                {
                    Maksimum.Add(Maksimum[i-1]);
                }
            }
            
            List<int> sonuc = new List<int>() { sayacMax, sayacMin };
            return sonuc;     

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
