public class Solution {
    public int TitleToNumber(string s) {
        var sum = 0;
        var offset = 0;
        for (int i = 0; i < s.Length; i++){
            sum = (s[i] - 'A' + 1) + sum *26;
        }
        return sum;
    }
}
