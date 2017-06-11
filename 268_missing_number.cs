public class Solution {
    public int MissingNumber(int[] nums) {
        var sorted_map = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length + 1; i++){
            sorted_map[i] = -1;
        }
        for (int i = 0; i < nums.Length; i++){
            sorted_map[nums[i]] = 1;
        }
        for (int i = 0; i < sorted_map.Length; i++){
            if (sorted_map[i] == -1){
                return i;
            }
        }
        
        return nums.Length;
    }
}
