public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var dict = new Dictionary<string, int>();
        for(int i = 0; i < strs.Length; i++){
            var val = strs[i];
            var prefix = "";
            for (int j = 0; j < val.Length; j++){
                prefix += val[j];
                int count = 1;
                if (dict.TryGetValue(prefix, out count)){
                    dict[prefix] += 1; 
                }
                else {
                    dict[prefix] = 1;
                }
            }
        }
        
        var longestCommon = "";
        foreach (var item in dict){
            if (item.Value == strs.Length){
                if (item.Key.Length > longestCommon.Length){
                    longestCommon = item.Key;
                }
            }
        }
        
        return longestCommon;
    }
}
