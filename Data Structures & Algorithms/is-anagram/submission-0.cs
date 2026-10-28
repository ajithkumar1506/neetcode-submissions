public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        if (s == t) {
            return true;
        }

        int[] counts = new int[26];
        for (int i = 0; i < s.Length; i++) {
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }

        foreach (int n in counts) {
            if ( n != 0) {
                return false;
            }
        }

        return true;
    }
}
