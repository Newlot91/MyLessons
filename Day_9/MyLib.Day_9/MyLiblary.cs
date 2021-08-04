using System;

namespace MyLib
{
    public class MyLiblary
    {
        /// <summary>
        /// Get string and return number of numbers in string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetNumberOfNumbersInString(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c))
                    result++;
            }
            return result;
        }


        /// <summary>
        /// Get array of strings and return longest word in string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMaxWord(string[] s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (result.Length < s[i].Length)
                    result = s[i];
            }
            return result;
        }


        /// <summary>
        /// Get string URI(formation) and return host name.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string GetHostNameFromURI(string uri)
        {
            string result = "";
            string[] data = new string[0];
            int countForData = 0;
            int start = 0;
            int end;
            char[] charArray = new char[uri.Length];
            for (int i = 0; i < uri.Length; i++)
            {
                charArray[i] = uri[i];
                if (uri[i] == '/')
                {                    
                    Array.Resize(ref data, countForData+1);
                    end = i;
                    data[countForData] = new string(charArray[start..end]);
                    countForData++;
                    start = end+1;
                }
            }
            return result = data[2];
        }


        /// <summary>
        /// Get string URI(formation) and return protocol type.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string GetProtocolFromURI(string uri)
        {
            string result = "";
            char[] charArray = new char[uri.Length];
            int countForData = 1;
            for (int i = 0; i < uri.Length; i++)
            {   
                if (uri[i] == ':')
                    break;
                Array.Resize(ref charArray, countForData);
                countForData++;
                charArray[i] = uri[i];
            }
            return result = new string(charArray);
        }
    }
}
