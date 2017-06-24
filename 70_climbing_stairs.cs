public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];
        return rClimbStairs(n, 0, memo);
    }
    
    public int rClimbStairs(int n, int currN, int[] memo){
        if (n == currN){
            return 1;
        }
        if (n < currN){
            return 0;
        }
        if (memo[currN] > 0){
            return memo[currN];
        }
        
        memo[currN]= rClimbStairs(n, currN +1, memo) + rClimbStairs(n, currN +2, memo);
        return memo[currN];
    }
}
