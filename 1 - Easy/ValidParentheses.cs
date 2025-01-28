namespace LeetCode._1___Easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (c is '[' or '(' or '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();
                if ((c == ']' && top != '[') ||
                    (c == '}' && top != '{') ||
                    (c == ')' && top != '('))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
