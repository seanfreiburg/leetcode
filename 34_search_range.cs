public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var numList = nums.ToList();
        int startIdx;
        int endIdx;
        try {
            startIdx= numList.IndexOf(target);
        }
        catch (System.InvalidOperationException){
            startIdx= -1;
        }
        
        try {
            endIdx = numList.LastIndexOf(target);
        }
        catch (System.InvalidOperationException){
            endIdx= -1;
        }
        return new int[]{startIdx, endIdx};
    }
}
