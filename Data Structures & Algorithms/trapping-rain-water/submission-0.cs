public class Solution {
    public int Trap(int[] height) {
        if (height.Length == 0) {
            return 0;
        }

        int l = 0;
        int r = height.Length - 1;
        int leftMax = height[l];
        int rightMax = height[r];
        int result = 0;

        while (l < r) {
            if (leftMax < rightMax) {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                result += leftMax - height[l];
            }
            else {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                result += rightMax - height[r];
            }
        }

        return result;
    }
}
