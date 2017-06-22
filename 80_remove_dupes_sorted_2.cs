public class Solution {
    public int RemoveDuplicates(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++){
            if (dict.ContainsKey(nums[i])){
                if (dict[nums[i]] < 2){
                   dict[nums[i]]++; 
                }
            }
            else {
                dict[nums[i]] = 1;
            }
        }
        
        var sum = 0;
        var inx = 0;
        foreach (var key in dict.Keys){
            for (int i = 0; i < dict[key]; i++){
                nums[inx] = key;
                inx += 1;
            }
            sum += dict[key];
        }
        return sum;
    }
}
