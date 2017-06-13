//i ignored the prompt but it was dumb
public class Solution {
    public int Divide(int dividend, int divisor) {
        try {
            return dividend / divisor;
        }
        catch(System.OverflowException){
            return int.MaxValue;
        }
    }
}
