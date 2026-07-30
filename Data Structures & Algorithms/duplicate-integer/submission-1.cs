public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> a = new HashSet<int>(nums);
        if (a.Count != nums.Length)
        {
            return true;
        }
        return false;
    }
}