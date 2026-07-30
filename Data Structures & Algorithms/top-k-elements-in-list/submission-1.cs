public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> num = new Dictionary<int,int>();
        for(int i = 0;i < nums.Length; i++) 
        {
            if(num.ContainsKey(nums[i]))
            {
                num[nums[i]]++;
            }else{
                num[nums[i]] = 1;
            }
        }
        return num.Keys.OrderByDescending(x => num[x]).Take(k).ToArray();
    }
}
