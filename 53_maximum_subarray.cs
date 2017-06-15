public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int left = 0;
        int right = 0;
        int currSum = nums[0];
        int max = nums[0];
        while (left < nums.Length && right < nums.Length -1){
            right += 1;
            if (nums[right] > currSum && currSum < 0){
                left = right;
                currSum = nums[right];
            }
            else {
                currSum = currSum + nums[right]; 
            }
            
            if (currSum > max){
                max = currSum; 
            }
        }
        
        return max;
    }
}
