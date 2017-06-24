public class Solution {
    public IList<string> FizzBuzz(int n) {
        var list = new List<string>();
        for (int i = 1; i <= n; i++){
            var str = "";
            if (i % 3 == 0 && i % 5 == 0){
                str += "FizzBuzz";
            }
            else if (i % 3 == 0){
                str += "Fizz";
            }
            else if (i % 5 == 0){
               str += "Buzz"; 
            }
            else {
                str += i.ToString();
            }
            list.Add(str);
        }
        
        return list;
    }
}
