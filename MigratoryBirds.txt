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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
          int tur1 = 0;
            int tur2 = 0;
            int tur3 = 0;
            int tur4 = 0;
            int tur5 = 0;

            foreach (int i in arr)
            {
                switch (i)
                {
                    case 1:
                        tur1++;
                        break;
                    case 2:
                        tur2++;
                        break;
                    case 3:
                        tur3++;
                        break;
                    case 4:
                        tur4++;
                        break;
                    case 5:
                        tur5++;
                        break;
                    default:
                        break;
                }
            }
            List<int> list = new List<int>() { tur1, tur2 , tur3 ,tur4, tur5 };

            if (tur1 == list.Max())
                return 1;
            else if (tur2 == list.Max())
                return 2;
            else if (tur3 == list.Max())
                return 3;
            else if (tur4 == list.Max())
                return 4;
            else
                return 5;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
