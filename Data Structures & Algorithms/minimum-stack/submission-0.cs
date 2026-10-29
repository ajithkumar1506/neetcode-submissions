public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        int value = minStack.Count == 0 ? val : minStack.Peek();
        minStack.Push(Math.Min(val, value)); 
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
