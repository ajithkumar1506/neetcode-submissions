public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        int l = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int r = 0; r < s.Length; r++) {
            if (map.TryGetValue(s[r], out int val)) {
                l = Math.Max(val + 1, l);
            }

            map[s[r]] = r;
            result = Math.Max(result, r - l + 1);
        }

        return result;
    }
}
