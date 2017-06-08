public class Solution {
    public string ComplexNumberMultiply(string a, string b) {
        var split_a = a.Split('+');
        var split_b = b.Split('+');
        var a_a = Int32.Parse(split_a[0]);
        var a_b = Int32.Parse(split_b[0]);
        
        var b_a = Int32.Parse(split_a[1].Split('i')[0]);
        var b_b = Int32.Parse(split_b[1].Split('i')[0]);
        
        var out_a = a_a * a_b - b_a * b_b;
        
        var out_b = (a_a* b_b) + (b_a * a_b);
        
        return out_a.ToString() + "+" + out_b.ToString() + "i";
    }
}
