public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int value = nums[i];
            int compliment = target - value;

            if (map.ContainsKey(compliment)) {
                return new int[] {map[compliment], i};
            }

            map.TryAdd(value, i);
        }

        return new int[0];
    }
}
