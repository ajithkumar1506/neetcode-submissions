public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> brackets = new Dictionary<char, char>
        {
            [']'] = '[',
            [')'] = '(',
            ['}'] = '{'
        };

        foreach (char c in s) {
            if (brackets.TryGetValue(c, out char openTag)) {
                if (stack.Count > 0 && stack.Peek() == openTag) {
                    stack.Pop();
                }
                else {
                    return false;
                }
            }
            else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
