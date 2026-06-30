using LeetCode_Task;
using System.Numerics;
/* //N1
int[] nums = [3, 2, 4];
int target = 6;

int [] index= Solution1.TwoSum(nums, target);

for (int i = 0; i < index.Length; i++)
{
    Console.WriteLine(index[i]);
}
*/



int[] digits = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };

var result = Solution1.PlusOne(digits);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

public static class Solution1
{
    public static int[] TwoSum(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = +1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == k)
                {
                    return new int[] { i, j };
                }

            }
        }
        return null;
    }


    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        if (x < 10 && x>=0)
        {
            return true;   
        }
        

        int s=0, t=x;
        bool result=false;

        while (x >= 10)
        {
            int d = x % 10;
            x = x / 10;


            s = (s + d) * 10;

            d = x;

            if (x < 10)
            {
                s = s + d;


                if (t == s)
                {
                    result = true;
                }
            }

           


            

        }

        return result;  

    }



    public static int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;

    }



}