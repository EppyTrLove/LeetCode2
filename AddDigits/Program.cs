class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AddDigits(12));
    }

    public static int AddDigits(int num)
    {
        var s = 0;
        while(num !=0)
        {
            s += num % 10;
            num = num / 10;
        }
        if (s < 10)
            return s;
        return AddDigits(s);

    }
}

