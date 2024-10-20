using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int val = Math.Abs(nums[i]) - 1;
                    if (nums[val] > 0)
                    {
                        nums[val] = -nums[val];
                    }
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1);
                    }
                }
                return new List<int>(result); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                int[] result = new int[nums.Length];
                int even = 0, odd = nums.Length - 1;

                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        result[even++] = num;
                    }
                    else
                    {
                        result[odd--] = num;
                    }
                }

                Array.Reverse(result, even, nums.Length - even);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int numNeeded = target - nums[i];
                    if (map.ContainsKey(numNeeded))
                    {
                        return new int[] { map[numNeeded], i };
                    }
                    map[nums[i]] = i;
                }
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);

                int n = nums.Length;
                int max1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
                int max2 = nums[0] * nums[1] * nums[n - 1]; 

                return Math.Max(max1, max2);
                //return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNum)
        {
            try
            {
                if (decimalNum == 0) return "0";

                string binary = "";
                while (decimalNum > 0)
                {
                    binary = (decimalNum % 2) + binary;
                    decimalNum /= 2;
                }
                return binary;
                // return "101010"; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int min = nums[0];
                foreach (int num in nums)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
                //return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false;

                string str = x.ToString();
                int len = str.Length;

                for (int i = 0; i < len / 2; i++)
                {
                    if (str[i] != str[len - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
                //return false; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n < 0 || n > 30)
                {
                    Console.WriteLine("n should be between 0 and 30. Please try again. ");
                }

                if (n <= 1) return n;
                int a = 0, b = 1, sum;
                for (int i = 2; i <= n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                }
                return b;
                //return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
