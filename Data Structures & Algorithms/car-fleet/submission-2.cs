public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        (int pos, int spd)[] pairs = new (int, int)[position.Length];

        for (int i = 0; i < position.Length; i++) {
            pairs[i] = (position[i], speed[i]);
        }

        Array.Sort(pairs, (a, b) => b.pos.CompareTo(a.pos));

        Stack<double> stack = new Stack<double>();
        foreach (var pair in pairs) {
            stack.Push((double)(target - pair.pos) / pair.spd);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }

        return stack.Count;
    }
}
