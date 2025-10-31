public partial class Solution
{
    public int RomanToInt(string s)
    {
        int res = 0;

        Dictionary<char, int> d = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                res += d[s[i]];
            }
            else
            {    
                if (d[s[i + 1]] > d[s[i]])
                {
                    res -= d[s[i]];
                }
                else
                {
                    res += d[s[i]];
                }
            }
        }

        return res;
    }
}