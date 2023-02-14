using System.Net.Http.Headers;

class Program
{
    public static void Main(string[] args)
    {
        var arr = new[] { 0, 2, 1, 4, 5 };
        Console.WriteLine(MissingNumber(arr));
    }

    public static int MissingNumber(int[] nums)
    {
        for (int i = 0; i <= nums.Length; i++)
        {
            if (nums.Contains(i) == false)
                return i;
        }
        return -1;
        //var resutl = 0;
        //Array.Sort(nums);
        //if (nums[0] == 1) return 0;
        //if (nums.Length == 1) return 1;

        //for (var i = 1; i < nums.Length; i++)
        //{
        //    if (nums.Length == 2 && nums[i - 1] != nums[i] - 1)
        //        resutl = nums[i] - 1;
        //    else if (nums.Length == 2 && nums[i - 1] == nums[i] - 1)
        //        resutl = 2;
        //    else if (nums.Length != 2 && nums[i - 1] != nums[i] - 1)
        //        resutl = nums[i] - 1;
        //}
        //return resutl;
    }
}