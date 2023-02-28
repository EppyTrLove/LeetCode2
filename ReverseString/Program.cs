class Program
{
    public static void Main(string[] args)
    {
        var s = new [] { 'h', 'o', 'l', 'z' };
        ReverseString(s);
        foreach (var c in s)
            Console.WriteLine(c);
    }


    public static void ReverseString(char[] s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            var temp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i -1] = temp;
        }

    }
}