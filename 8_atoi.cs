public class Solution {
    public int MyAtoi(string str) {
        str = str.Trim();
        var val = 0;
        var sign = 1;
        if (str.Length == 0){
            return 0;
        }
        var start_index = 0;
        if (str[0] == '+'){
            start_index = 1;
        } 
        else if (str[0] == '-'){
            sign = -1;
            start_index = 1;
        } 
        for (int i = start_index; i < str.Length; i++){
            if (str[i] > '9' || str[i] < '0'){
                return val;
            }
            if (val >= int.MaxValue/10){
                return int.MaxValue;
            }
            
            if (val <= int.MinValue/10 && str[i] - '0' > 7){
                return int.MinValue;
            }
            val = (val * 10) + (str[i] - '0')*sign;
        }
        return val;
    }
}
