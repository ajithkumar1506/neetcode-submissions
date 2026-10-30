public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers.Length < 2) {
            return new int[0];
        }

        int left = 0;
        int right = numbers.Length - 1;
        while (left < right) {
            int sum = numbers[left] + numbers[right];

            if (sum == target) {
                return new int[] { left + 1, right + 1 };
            }
            else if (sum > target) {
                right--;
            }
            else if (sum < target) {
                left++;
            }
        }

        return new int[0];
    }
}
