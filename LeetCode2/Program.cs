class Program
{
    public static void Main(string[] args)
    {

       Console.WriteLine(IsPowerOfTwo(1073741825));
    }


    public static bool IsPowerOfTwo(int n)
    {

        return Math.Log2(n) % 1 == 0;

        //for (int x = 1; x <= n; x *= 2)
        //{
        //    if (x == n) return true;
        //}
        //return false;


        //var result = false;
        //var i = 1;
        //while (i < n)
        //    i = i * 2;
        //if (i == n)
        //   result = true;
        //else
        //    result = false;
        //return result;

    }
}
