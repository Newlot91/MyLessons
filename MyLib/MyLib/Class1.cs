using System;

namespace MyLib
{
    public class MyLibrary
    {
    /// <summary>
    /// Find all numbers with your Digit in array
    /// </summary>
    /// <param name="myArray">Array of digits</param>
    /// <param name="Digit">Digit that you find in array</param>
        public static int[] FilterDigit(int[] myArray, int Digit)
        {
            int i = 0;
            for (; i < myArray.Length; i++)
            {
                string[] myStringArray = new string[myArray.Length];
                myStringArray[i] = myArray[i].ToString();               
                }
                    if (myStringArray[i].Contains(Digit.ToString()))
                {
                    int n = 0;
                    n++;
                    string[] FilteredArray = new string[n];
                    FilteredArray[n] = myStringArray[i]; //Как сделать массив string->int?
                    Console.WriteLine(FilteredArray[n]);
                }
            }
        }
        
    }
}
       