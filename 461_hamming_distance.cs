public class Solution {
    public int HammingDistance(int x, int y) {
        int xord = x ^ y;
        var output = 0;
        while (xord != 0){
            if ((xord & 1) == 1){
                output += 1;
            }
            xord = xord >> 1;
        }
        return output;
    }
}
