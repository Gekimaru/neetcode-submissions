public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> countNumber = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach (int n in nums) {
            if (countNumber.ContainsKey(n)){
                countNumber[n]++;
            } else {
                countNumber[n] = 1;
            }
        }
        
        foreach (var entr in countNumber) {
            freq[entr.Value].Add(entr.Key);
        }

        int[] result = new int[k];
        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in freq[i]) {
                result[index++] = n;
                if (index == k) {
                    return result;
                }
            }
        }

        return result;

    }
}
