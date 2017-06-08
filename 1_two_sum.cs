public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++){
            var curr = nums[i];
            int diff = target - curr;
            int second_index = -1;
            if (dict.TryGetValue(diff, out second_index) && i != second_index){
                return new int[]{i, second_index};
            }
            if (!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
            
        }
        return new int[]{-1,-1};
    }
}
