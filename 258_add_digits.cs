public class Solution {
    public int AddDigits(int num) {
        var numStr = num.ToString();
        var numArr = numStr.ToCharArray();
        while (numArr.Length > 1){
            var sum = 0;
            for (int i = 0; i < numArr.Length; i++){
                sum += Int32.Parse(numArr[i].ToString());
            }
            numStr = sum.ToString();
            numArr = numStr.ToCharArray();
        }
        return Int32.Parse(string.Join("", numArr));
    }
}
