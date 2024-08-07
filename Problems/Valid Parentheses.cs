public partial class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            char p = stack.Pop();

            if (p == '(' && c == ')')
            {
                continue;
            }

            if (p == '[' && c == ']')
            {
                continue;
            }

            if (p == '{' && c == '}')
            {
                continue;
            }

            return false;
        }

        return (stack.Count == 0);
    }
}