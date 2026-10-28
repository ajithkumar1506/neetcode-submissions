public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] charCount = new int[26];
            StringBuilder sb = new StringBuilder();

            foreach (char c in s) {
                charCount[c - 'a']++;
            }

            for (int i = 0; i < 26; i++) {
                sb.Append(charCount[i]);
                sb.Append('#');
            }

            string key = sb.ToString();

            if (!map.TryGetValue(key, out List<string> value)) {
                value = new List<string>();
                map[key] = value;
            }

            value.Add(s);
        }

        return new List<List<string>>(map.Values);
    }
}
