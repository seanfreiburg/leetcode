public class Solution {
    public bool IsValid(string s) {
        var stack = new List<char>();
        for (int i = 0; i < s.Length; i++){
            var val = s[i];
            if (val == '(' || val == '{' || val == '['){
                stack.Add(val);
            }
            else {
                if (stack.Count > 0 && 
                ((stack.Last() == '(' && val == ')') ||
                (stack.Last() == '{' && val == '}') ||
                (stack.Last() == '[' && val == ']')
                )){
                    stack.RemoveAt(stack.Count -1);
                }
                else {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
