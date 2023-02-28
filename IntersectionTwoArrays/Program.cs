class Program
{
    public static void Main(string[] args)
    {
        var s = new[] { 'h', 'o', 'l', 'z' };
        ReverseString(s);
        foreach (var c in s)
            Console.WriteLine(c);
    }


    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        var list = new List<int>();
        for (var i = 0; i < nums1.Length; i++)
        {
            for (var j = 0; j< nums2.Length; j++)
                if (nums1[i] == nums2[j])
                    list.Add(nums1[i]);
        }
        return list.Distinct().ToArray();
    }
}