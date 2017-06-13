public class Solution {
    public int MajorityElement(int[] nums) {
        var maxKey = -1;
        var maxVal = -1;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int value = 0;
            if (dict.TryGetValue(nums[i], out value)){
                dict[nums[i]] += 1;
            }
            else {
                dict[nums[i]] = 1;
            }
        }
        
        foreach(var item in dict){
            if (item.Value > maxVal){
                maxVal = item.Value;
                maxKey = item.Key;
            }
        }
        return maxKey;
    }
}
