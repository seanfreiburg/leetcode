public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] new_nums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++){
            var new_nums_index = (i + k ) % nums.Length;
            new_nums[new_nums_index] = nums[i];
        }
        
        for (int i = 0; i < nums.Length; i++){
            nums[i] = new_nums[i];
        }
    }
}
