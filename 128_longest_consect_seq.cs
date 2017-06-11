public class Solution {
    public int LongestConsecutive(int[] nums) {
        var map = new Dictionary<int,int>();
        var max = 0;
        for (int i = 0; i < nums.Length; i++){
            if (!map.ContainsKey(nums[i])){
                var left = 0;
                var right = 0;
                if (map.ContainsKey(nums[i] - 1)){
                    left = map[nums[i] - 1];
                }
                if (map.ContainsKey(nums[i] + 1)){
                    right = map[nums[i] + 1];
                } 
                
                var sum = 1 + left + right;
                map[nums[i]] = sum;
                
                max = Math.Max(sum, max);
                
                map[nums[i] - left]  = sum;
                map[nums[i] + right] = sum;
            }
        }
        return max;
    }
}
