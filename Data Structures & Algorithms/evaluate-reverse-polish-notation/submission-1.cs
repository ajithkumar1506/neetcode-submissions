public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int parsedNum))
            {
                stack.Push(parsedNum);
            }
            else
            {
                int a = stack.Pop();
                int b = stack.Pop();
                switch (token)
                {
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "-":
                        stack.Push(b - a);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    default:
                        stack.Push((int)(double)b / a);
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
