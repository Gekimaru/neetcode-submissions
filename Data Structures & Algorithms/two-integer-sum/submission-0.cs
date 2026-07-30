public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
        int curr = nums[0];
        int next = nums[0];
        for(int i=0;i<nums.Length;i++){
            for(int j = i+1;j<nums.Length;j++){
                if(nums[i] + nums[j] == target){
                    
                    return new []{i,j};
                }
            }
        }
        return new []{0,0};
    }
}
