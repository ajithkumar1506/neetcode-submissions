public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> q = new LinkedList<int>();
        int l = 0;
        int r = 0;

        while (r < n) {
            while (q.Count > 0 && nums[q.Last.Value] < nums[r]) {
                q.RemoveLast();
            }
            q.AddLast(r);

            if (l > q.First.Value) {
                q.RemoveFirst();
            }

            if ((r + 1) >= k) {
                result[l] = nums[q.First.Value];
                l++;
            }

            r++;
        }

        return result;
    }
}
