public class Solution {
    public string ReverseWords(string s) {
        string[] str = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        var strList = str.ToList();
        strList.Reverse();
        return String.Join(" ", strList.ToArray()).Trim();
    }
}
