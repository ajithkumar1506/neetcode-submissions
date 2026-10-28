public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (string s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int delimiterIdx = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, delimiterIdx - i));
            int startId = delimiterIdx + 1;

            result.Add(s.Substring(startId, length));
            i = startId + length;
        }

        return result;
   }
}
