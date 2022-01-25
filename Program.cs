using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();
         
        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string x)
        {
            try
            {
                String final_string1 = "";
                foreach (char i in x)
                {
                    if (i == 'a' || i == 'i' || i == 'e' || i == 'o' || i == 'u')
                    {
                        final_string1 += null;
                    }
                    else
                    {
                        final_string1 += i;
                    }

                }

                
                return final_string1;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}