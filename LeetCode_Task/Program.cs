using LeetCode_Task;
/* //N1
int[] nums = [3, 2, 4];
int target = 6;

int [] index= Solution1.TwoSum(nums, target);

for (int i = 0; i < index.Length; i++)
{
    Console.WriteLine(index[i]);
}
*/

int a = 11;

bool b=Solution1.IsPalindrome(a);
Console.WriteLine(b);

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







}