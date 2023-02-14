public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        foreach (var x in nums)
        {
            for (var i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }
            }
        }
    }
}
