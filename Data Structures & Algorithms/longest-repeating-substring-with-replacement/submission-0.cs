public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int result = 0;
        int l = 0;
        int maxFreq = 0;

        for (int r = 0; r < s.Length; r++) {
            if (count.TryGetValue(s[r], out int val)) {
                count[s[r]] = val + 1;
            }
            else {
                count[s[r]] = 1;
            }

            maxFreq = Math.Max(maxFreq, count[s[r]]);

            while((r - l + 1) - maxFreq > k) {
                count[s[l]]--;
                l++;
            }

            result = Math.Max(result, (r - l + 1));
        }

        return result;
    }
}
