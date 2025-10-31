namespace leetcode.easy;

public partial class Solution
{
    public bool IsValid(string s) {
        Stack<char> st = [];
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                st.Push(c);
            }
            else
            {
                if (st.Count == 0) return false;

                if (c == '}')
                {
                    if (st.Peek() != '{') return false;
                }
                else if (c == ']')
                {
                    if (st.Peek() != '[') return false;
                }
                else
                {
                    if (st.Peek() != '(') return false;
                }
                    st.Pop();

            }
        }
        return st.Count == 0;
    }
}