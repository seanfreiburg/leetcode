public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < s.Length -1; i += 1){
            if (i + 10 <= s.Length){
               var substring = s.Substring(i, 10);
            
                if (dict.ContainsKey(substring)){
                    dict[substring] = dict[substring] +1;
                }
                else {
                    dict.Add(substring, 1);
                } 
            }
        }
        
        var repeated = new List<string>();
        foreach(var item in dict)
        {
            if (item.Value > 1){
                repeated.Add(item.Key);
            }
        }
        return repeated;
    }
}
