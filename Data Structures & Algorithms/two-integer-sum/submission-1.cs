public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i ++) {

            if (map.ContainsKey(nums[i])) {
                var res = new int[2];
                res[0] = map[nums[i]];
                res[1] = i;
                return res;
            }
            else {
                map.Add(target - nums[i], i);
            }
        }
        return new []{0,0};
    }
}
