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
            //letting user to pass input
            string final_string = RemoveVowels(s);
            //passing the input string to call a method
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();
            
            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "of", "southFlorida" };
            string[] bulls_string2 = new string[] { "marshalofSouthFlorida" };
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
            int[] bull_bucks = new int[] { 1, 5, 4, 4, 4};
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array is : {0}", unique_sum);
            Console.WriteLine();

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is "+ rotated_string);
            Console.WriteLine();
            

            //Quesiton 6:
            string bulls_string6 = "abcdefd";
            char ch = 'd';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();

        }

        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string1 = "";
                foreach (char i in s)
                //executing for loop to check each charecter in the string s
                {
                    if (i == 'a' || i == 'i' || i == 'e' || i == 'o' || i == 'u' || i == 'A' || i == 'I' || i == 'E' || i == 'O' || i == 'U')
                    {
                        final_string1 += "";
                    }
                    else
                    {
                        final_string1 += i;
                    }
                    //if the charecter in the string doesnot matches the above requiremet, adding it to an empty string
                }


                return final_string1;
            
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string newString1 = "";
                foreach (string j in bulls_string1)
                {
                    foreach (char i in j)
                    {
                        newString1 += i;
                    }
                }
                //adding all the charecters in a given array to a new string
                string newString2 = "";
                foreach (string k in bulls_string2)
                {
                    foreach (char l in k)
                    {
                        newString2 += l;
                    }
                }
                if (newString1.ToLower() == newString2.ToLower())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //as it's case insensitive, coverting it to lower case and then comparing both the strings
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
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
                //storing -1 values to a new array x and with having the length of the input array 
                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    sum += bull_bucks[i];

                    int repeatedNo = 1;
                    for (int j = i + 1; j < bull_bucks.Length; j++)
                    {
                        if (bull_bucks[i] == bull_bucks[j])
                        {
                            repeatedNo++;
                            x[j] = 0;
                        }

                    }
                    //checking for the unique elements in the passed array by passing 0 if it matches any other elements in a given array
                    if (x[i] != 0)
                    {
                        x[i] = repeatedNo;
                    }
                    //counting how many times an element is repeated
                }
                for (int k = 0; k < bull_bucks.Length; k++)
                {
                    if (x[k] > 1)
                    {
                        sum -= (x[k] * bull_bucks[k]);
                    }
                }
                //from the total sum, subtracting the repeated values and counting only the unique elements
                return sum;

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int sum = 0;
                if (bulls_grid.GetLength(0) == bulls_grid.GetLength(1)) 
                //checking whether the given matrix is a square matrix
                {
                    for (int i = 0; i < bulls_grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < bulls_grid.GetLength(1); j++)
                        {
                            if (i == j)
                            {
                                sum += bulls_grid[i, j];
                            }
                            //counting the values of the diagonal values
                            if (i+j == bulls_grid.GetLength(0)-1)
                            {
                                sum += bulls_grid[i, j];
                            }
                            //counting the values of the counter diagonal values
                            
                        }
                    }
                    if (bulls_grid.GetLength(0) % 2 != 0)
                    {
                        int repeated = (bulls_grid.GetLength(0) - 1) / 2;
                        sum -= bulls_grid[repeated, repeated];
                    }
                    //if the given matrix is odd, subtracting the intesected value

                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                char[] x = bulls_string.ToCharArray();
                char[] y = new char[bulls_string.Length];
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    y[indices[i]] = x[i];
                }
                //alligning all the charecters in the string as per the given indices
                string rotated_string = "";
                for (int m = 0; m < bulls_string.Length; m++)
                {
                    rotated_string += y[m];
                }
                return rotated_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                        //reversing the index of the charecters when it finds the 1st occurance
                   }
                    //run stops after checking the 1st occurance of the given charecter
                    y[i] = x[i];
                    //continuing with the same charecters after reversing the given values
                }
                string prefix_string = "";
                for (int m = 0; m < bulls_string6.Length; m++)
                {
                    prefix_string += y[m];
                }
                return prefix_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        
    }
}

/*
Self Reflection:

Question1: 
time taken     - 10min
learnings      - how to use methods, foreach and if statments
recommendation - Would be helpful if there is anything about case sensitivity, 'aeiou' 'AEIOU'

Question2: 
time taken     - 15min
learnings      - using boolean, try and catch
recommendation - case sensitivity constarint would be more helpful

Question3: 
time taken     - 25min
learnings      - identifying unique elements in agiven array by using and new array with a logic

Question4: 
time taken     - 30min
learnings      - using getlength method to know number of rows and columns in a matrix

Question5: 
time taken     - 25min
learnings      - alligning charecters in a string for a given indices

Question6: 
time taken     - 35min
learnings      - using flag to find the 1st occurance of a given charecter in a given string
*/