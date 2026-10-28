public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> counts = new HashSet<int>();

        foreach (int n in nums) {
            if(!counts.Add(n)) {
                return true;
            }
        }

        return false;
    }
}