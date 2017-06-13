public class Solution {
    public int[] PlusOne(int[] digits) {
        var carry = 1;
        int i = digits.Length -1;
        while (carry > 0){
            var sum = digits[i] + 1;
            if (sum >= 10){
                digits[i] = sum - 10;
                carry = 1;
            }
            else {
                digits[i] = sum;
                carry = 0;
            }
            if (carry > 0 && i <= 0){
                var newDigits = new int[digits.Length + 1];
                for (int j = 1; j < digits.Length; j++){
                    newDigits[j] = digits[j-1];
                }
                newDigits[0] = carry;
                return newDigits;
            }
            i = i - 1;
        }
        
        return digits;
    }
}
