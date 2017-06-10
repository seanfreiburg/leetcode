// https://leetcode.com/problems/longest-absolute-file-path/#/description
using System;
using System.Text.RegularExpressions;

public class Solution {
    public int LengthLongestPath(string input) {
        var input_arr = input.Split(new string[] {"\n" }, StringSplitOptions.RemoveEmptyEntries);
        var max_len = 0;
        var stack = new List<string>();
        
        for (int i =0; i < input_arr.Length; i++){
            var tab_depth = Regex.Matches(input_arr[i],  "\t").Count;
            if (tab_depth < stack.Count){
                while (tab_depth < stack.Count){
                    //return tab_depth;
                    stack.RemoveAt(stack.Count - 1);
                }
                
            }
            if (input_arr[i].Contains(".") && input_arr[i].Split('.')[1].Length > 0){
                // is a file
                var path = input_arr[i].Split(new string[] {"\t"}, StringSplitOptions.RemoveEmptyEntries).Last().Length;
                foreach (var dir in stack){
                    path += dir.Length;
                }
                if (path > max_len){
                    max_len = path;
                }
            } else {
                stack.Add(input_arr[i].Split(new string[] {"\t"}, StringSplitOptions.RemoveEmptyEntries).Last() + "a");
            }
        }
        return max_len;
    }
}
