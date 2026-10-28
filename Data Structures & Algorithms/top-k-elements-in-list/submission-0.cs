public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];

        foreach (int n in nums) {
            counts[n] = counts.GetValueOrDefault(n, 0) + 1;
        }

        foreach (var pair in counts) {
           int key = pair.Key;
           int value = pair.Value;

           if (freq[value] == null) {
                freq[value] = new List<int>();
           }

           freq[value].Add(key);
        }

        int[] result = new int[k];
        int index = 0;
        for(int i = freq.Length - 1; i > 0 && index < k; i--) {
            if (freq[i] == null) {
                continue;
            }

            foreach(int n in freq[i]) {
                result[index] = n;
                index++;
                
                if (index == k) {
                    return result;
                }
            }
        }

        return result;
    }
}
