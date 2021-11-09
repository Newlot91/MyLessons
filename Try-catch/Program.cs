using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NullRefExepcion(null);

                int[] nums = new int[2];
                IndexOutOfRange(nums, 5);

                Object obj = "one";
                int aa = (Int32)obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine();
            }

            //With throw
            void NullRefExepcion(string line)
            {
                if (line == null)
                {
                    throw new Exception("Null reference");
                }
                else
                {
                    Console.WriteLine("Value is not NULL");
                }
            }            
            void IndexOutOfRange(int []nums,int indexOfNum )
            {
                if (indexOfNum> nums.Length)
                {
                    throw new Exception("Index out of the range");
                }
                else
                {
                    Console.WriteLine($"Array lenght is {nums.Length}\nSelected index is {indexOfNum}");
                }
            }
            void CastExcepcion()//не знаю как выполнить проверку
            {

            }
        }
    }
}
