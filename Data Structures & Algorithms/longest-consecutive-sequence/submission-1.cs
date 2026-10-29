public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> numsMap = new Dictionary<int, int>();
        int longest = 0;

        foreach (int num in nums) {
            if (!numsMap.ContainsKey(num)) {
                int left = numsMap.GetValueOrDefault(num - 1, 0);
                int right = numsMap.GetValueOrDefault(num + 1, 0);
                int val = left + right + 1;

                numsMap[num] = val;
                numsMap[num - left] = val;
                numsMap[num + right] = val;

                longest = Math.Max(longest, val);
            }
        }

        return longest;
    }
}
