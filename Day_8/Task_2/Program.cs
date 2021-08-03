using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 1, 2, 3 };
            Console.WriteLine(shuffledString(s, indices));
        }
        public static string shuffledString(string s, int[] indices)
        {
            string result = s;
            char[] temp = new char[indices.Length];
            int c;
            for (int i = 0; i < s.Length; i++)
            {
                c = indices[i]; 
                temp [c]= s[i]; // result [indices[c]]= s[i] ; не удаётся перезаписать значение.
            }

            return result = new String(temp);
        }
    }
}
