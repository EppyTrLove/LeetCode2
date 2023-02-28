class Program
{
    public static void Main(string[] args)
    {
        var str = @"C:\Solvery1\File_DataBase.txt";
        var str1 = "";
        Console.WriteLine(str.Substring(str.LastIndexOf(@"\"), str.Length-1));
    }
}   