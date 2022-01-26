using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            /*Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();
            
            //Question 2:
            string[] bulls_string1 = new string[] { "University", "of", "SouthFlorida" };
            string[] bulls_string2 = new string[] { "UniversityofSouthFlorida" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();
            

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 4, 5};
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array is : {0}", unique_sum);
            Console.WriteLine();
            

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is "+ rotated_string);
            Console.WriteLine();
            

            //Quesiton 6:
            string bulls_string6 = "zimmermanschoolofadvertising";
            char ch = 'x';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();
*/
            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int sum = 0;
                if (bulls_grid.GetLength(0) == bulls_grid.GetLength(1)) 
                {
                    if (bulls_grid.GetLength(0) % 2 != 0)
                    {
                        int repeat = (bulls_grid.GetLength(0) - 1) / 2;
                        sum -= bulls_grid[repeat, repeat];
                    }
                    for (int i = 0; i < bulls_grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < bulls_grid.GetLength(1); j++)
                        {
                            if (i == j)
                            {
                                sum += bulls_grid[i, j];
                            }
                            if (i+j == bulls_grid.GetLength(0)-1)
                            {
                                sum += bulls_grid[i, j];
                            }
                            
                        }
                    }
              
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                char[] x = bulls_string6.ToCharArray();
                char[] y = new char[bulls_string6.Length];
                bool flag = true;
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                if (flag)
                    {
                        if (x[i] == ch)
                        {
                            int k = 0;
                            for (int l = i; l >= 0; l--)
                            {
                                y[k] = x[l];
                                k++;
                            }
                            flag = false;
                            i++;

                        }
                    }    
                    y[i] = x[i];

                }
                string z = "";
                for (int m = 0; m < bulls_string6.Length; m++)
                {
                    z += y[m];
                }

                String prefix_string = z;
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                char[] x = bulls_string.ToCharArray();
                char[] y = new char[bulls_string.Length];
                for (int i=0; i<bulls_string.Length; i++)
                {
                    y[indices[i]] = x[i]; 
                }
                string z = "";
                for (int m=0; m<bulls_string.Length; m++)
                {
                    z += y[m];
                }
                return z;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
    }
    private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int[] x = new int[bull_bucks.Length];
                int sum = 0;

                for (int l = 0; l < bull_bucks.Length; l++)
                {
                    x[l] = -1;
                }

                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    sum += bull_bucks[i];

                    int y = 1;
                    for (int j = i + 1; j < bull_bucks.Length; j++)
                    {
                        if (bull_bucks[i] == bull_bucks[j])
                        {
                            y++;
                            x[j] = 0;
                        }

                    }
                    if (x[i] != 0)
                    {
                        x[i] = y;
                    }

                }
                for (int k = 0; k < bull_bucks.Length; k++)
                {
                    if (x[k] > 1)
                    {
                        sum -= (x[k] * bull_bucks[k]);
                    }
                }

                return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string x1 = "";
                foreach (string j in bulls_string1)
                {
                    foreach (char i in j)
                    {
                        x1 += i;
                    }
                }

                string x2 = "";
                foreach (string k in bulls_string2)
                {
                    foreach (char l in k)
                    {
                        x2 += l;
                    }
                }
                if (x1 == x2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static string RemoveVowels(string x)
        {
            try
            {
                String final_string1 = "";
                foreach (char i in x)
                {
                    if (i == 'a' || i == 'i' || i == 'e' || i == 'o' || i == 'u' || i == 'A' || i == 'I' || i == 'E' || i == 'O' || i == 'U')
                    {
                        final_string1 += "";
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