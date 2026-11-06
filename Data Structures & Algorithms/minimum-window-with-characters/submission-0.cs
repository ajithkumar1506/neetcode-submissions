public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrWhiteSpace(t)) {
            return "";
        }

        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach (char c in t) {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        int have = 0;
        int need = countT.Count;
        int[] result = new int[] { -1, -1 };
        int resLength = int.MaxValue;

        int l = 0;
        for (int r = 0; r < s.Length; r++) {
            char c = s[r];
            window[c] = window.GetValueOrDefault(c, 0) + 1;
            
            if (countT.ContainsKey(c) && window[c] == countT[c]) {
                have++;
            }

            while (have == need) {
                int length = r - l + 1;
                if (length < resLength) {
                    resLength = length;
                    result[0] = l;
                    result[1] = r;
                }

                char leftChar = s[l];
                window[leftChar]--;

                if (countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }

                l++;
            }
        }

        return resLength == int.MaxValue ? "" : s.Substring(result[0], resLength);
    }
}
