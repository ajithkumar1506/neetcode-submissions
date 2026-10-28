public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = 0;

        foreach(int n in nums) {
            curSum = Math.Max(curSum, 0);
            curSum = curSum + n;
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}
