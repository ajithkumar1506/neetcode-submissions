public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string s in tokens) {
            if (s == "+") {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (s == "-") {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if (s == "*") {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (s == "/") {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push((int)((double)b / a));
            }
            else {
                stack.Push(int.Parse(s));
            }
        }

        return stack.Pop();
    }
}
