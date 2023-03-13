

public class Solution
{
    public int FirstUniqChar(string s)
    {
        foreach (var itm in s.Distinct())
        {
            if (s.Count(x => x == itm) == 1)
            {
                return s.IndexOf(itm);
            }
        }
        return -1;

    }
}
