using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Question1:
            Console.WriteLine("Question 1:");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");


            //Question 2 
            Console.WriteLine("\nQuestion 2:");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("\nQuestion 3:");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine("");

            //Question 4
            Console.WriteLine("Question 4:");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();
            Console.ReadKey();

            //Question 5
            Console.WriteLine("\nQuestion 5:");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine("");
            Console.ReadKey();

            //Question 6
            Console.WriteLine("Question 6:");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();
            Console.ReadKey();

            //Question 7

            //Question 8
            Console.WriteLine("Question 8:");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();
            Console.ReadKey();

            //Question 9
            Console.WriteLine("Question 9:");
            // int.MaxValue
            int a = 0;
            a = int.MaxValue;
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            //Console.WriteLine(a);
            Console.ReadKey();

            //Question 10
            Console.WriteLine("\nQuestion 10:");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine(Stairs(n10));
            Console.ReadKey();








        }

        //Question 1



       

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                

                int[] answer = new int[2 * n];
                int k = 0, m = n;
                for (int i = 0; i < 2 * n; i++)
                {

                    if (i % 2 == 0)
                        answer[i] = nums[k++];
                    else
                        answer[i] = nums[m++];
                }





                for (int i = 0; i < 2 * n; i++)
                    Console.Write(answer[i] + " ");
                Console.ReadKey();




            }
            catch (Exception)
            {
                throw;
            }

        }


        //Question 2

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                

                // Count of non-zero elements 
                int count = 0;

                // Count the length of array
                int n = ar2.Length;

                // Traverse the array. If element encountered is non-zero, then replace the element  
                for (int i = 0; i < n; i++)
                    if (ar2[i] != 0)

                        // here count is incremented 
                        ar2[count++] = ar2[i];

                // Now all non-zero elements have been shifted to 
                // Make all elements 0 from count to end. 
                while (count < n)
                    ar2[count++] = 0;

                // Print out array
                for (int i = 0; i < n; i++)
                    Console.Write(ar2[i] + " ");
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }

        }
        //Question 3
        private static void CoolPairs(int[] nums)
        {
            try
            {




                Dictionary<int, int> lookup = new Dictionary<int, int>();

                int count = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (lookup.ContainsKey(nums[i]))
                    {
                        count += lookup[nums[i]];
                        lookup[nums[i]]++;
                    }
                    else
                    { lookup[nums[i]] = 1; }
                }

                Console.WriteLine(count);
                Console.ReadKey();





            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4

        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                var dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(target - nums[i])) // checks if compliment is in dict
                    {
                        Console.Write("[{0},{1}]", dict[target - nums[i]], i);
                    }
                    else if (!dict.ContainsKey(nums[i])) // handles duplicates in array
                    {
                        dict.Add(nums[i], i);
                    }
                }

                return;

            }


            catch (Exception)
            {

                throw;
            }

        }


        //Question 5

        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //Sol1: 1. Store index with the string char and 2. return string based of indices char.
                char[] cArr = new char[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    cArr[indices[i]] = s[i];
                }

                Console.WriteLine(cArr);



            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6

        private static bool Isomorphic(string s, string t)
        {
            try
            {
                Dictionary<char, int> freqs = new Dictionary<char, int>();
                Dictionary<char, int> freqt = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!freqs.ContainsKey(s[i]))
                        freqs.Add(s[i], 0);
                    if (!freqt.ContainsKey(t[i]))
                        freqt.Add(t[i], 0);

                    if (freqs[s[i]] != freqt[t[i]])
                        return false;

                    freqs[s[i]] = i + 1;
                    freqt[t[i]] = i + 1;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
            //Question 7



            //Question 8

            private static bool HappyNumber(int n)

            {
                try
                {

                    HashSet<int> hset = new HashSet<int>() { n };
                    while (n != 1)
                    {
                        int nn = 0;
                        while (n > 0)
                        {
                            int d = n % 10;
                            nn += d * d;
                            n = n / 10;
                        }
                        if (!hset.Add(nn))
                            return false;
                        n = nn;
                    }
                    return true;

                   
                }
                catch (Exception)
                {

                    throw;
                }
            }


            //Question 9
            private static int Stocks(int[] prices)
            {
                try
                {
                    int minprice = int.MaxValue;
                    int maxprofit = 0;

                    for (int i = 0; i < prices.Length; i++)
                    {
                        if (prices[i] < minprice)
                        {
                            minprice = prices[i];
                        }
                        else if (prices[i] - minprice > maxprofit)
                        {
                            maxprofit = prices[i] - minprice;
                        }
                    }

                    return maxprofit;
                }
                catch (Exception)
                {

                    throw;
                }

            }

            //Question 10
            private static int Stairs(int n)
            {
                try
                {
                    int first = 1;
                    int second = 1;
                    while (n-- > 0)
                    {
                        int tmp = first;
                        first = second;
                        second = tmp + second;
                    }
                    return first;
                }
                catch (Exception)
                {

                    throw;
                }

            }



        }


    }





