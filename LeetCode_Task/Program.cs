using LeetCode_Task;

int[] nums = [3, 2, 4];
int target = 6;

int [] index= Solution1.TwoSum(nums, target);

for (int i = 0; i < index.Length; i++)
{
    Console.WriteLine(index[i]);
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
}