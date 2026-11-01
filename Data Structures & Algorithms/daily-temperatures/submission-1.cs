public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n];

        for (int i = n - 2; i >= 0; i--) {
            int next = i + 1;

            while (next < n && temperatures[next] <= temperatures[i]) {
                if (result[next] == 0) {
                    next = -1;
                    break;
                }

                next += result[next];
            }

            if (next != -1) {
                result[i] = next - i;
            }
        }

        return result;
    }
}
