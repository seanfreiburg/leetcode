public class Solution {
    public void MoveZeroes(int[] nums) {
        List<int> zeroIndexes = new List<int>();
        for (int i = 0; i < nums.Length; i ++){
            if (nums[i] == 0){
                zeroIndexes.Add(i);
            }
            else {
                if (zeroIndexes.Count > 0){
                    var zeroIndex = zeroIndexes[0];
                    nums[zeroIndex] = nums[i];
                    nums[i] = 0;
                    zeroIndexes.RemoveAt(0);
                    zeroIndexes.Add(i);
                }
            }
        }
    }
}
