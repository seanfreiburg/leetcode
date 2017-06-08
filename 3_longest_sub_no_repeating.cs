public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int start = 0;
        int end = 0;
        var dict = new Dictionary<char, int>();
        while (start < s.Length && end < s.Length){
            if (!dict.ContainsKey(s[end])){
                dict.Add(s[end], 0);
                if (end - start + 1 > max){
                    max = end - start + 1;
                }
                end = end + 1;
            }
            else {
                dict.Remove(s[start]);
                start = start + 1;
            }
            
        }
        
        return max;
    }
}
