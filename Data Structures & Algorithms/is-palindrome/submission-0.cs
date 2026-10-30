public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s)) {
            return true;
        }

        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            while (left < right && !IsAlphaNumeric(s[left])) {
                left++;
            }

            while (right > left && !IsAlphaNumeric(s[right])) {
                right--;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public bool IsAlphaNumeric(char c) {
        return ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'));
    }
}
