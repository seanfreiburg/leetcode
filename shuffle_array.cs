public class Solution {

public int[] pnums;
    public Solution(int[] nums) {
        pnums = nums;
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return pnums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        var list = pnums.ToList();
        return list.OrderBy(a => Guid.NewGuid()).ToArray();
    }
}
