public class Solution {
    public int FirstUniqChar(string s) {
        var length = 26;
        var chars = new int[length];
        for (int i = 0; i < length; i++ ){
            chars[i] = -1;
        }
        
        for (int i = 0; i < s.Length; i++){
            var index = (int)s[i] - (int)'a';
            if (chars[index] == -1){
                chars[index] = i;
            } 
            else if (chars[index] > -1){
                chars[index] = -2;
            }
        }
        
        var first = int.MaxValue;
        for (int i = 0; i < length; i++ ){
            if (chars[i] > -1){
                if (chars[i] < first){
                    first = chars[i];
                }
            }
        }
        return first != int.MaxValue ? first : -1;
    }
}
