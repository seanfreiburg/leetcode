public class Solution {
    public int WordsTyping(string[] sentence, int rows, int cols) {
        int count = 0;
        int curr_row = 0;
        int curr_col = 0;
        int curr_word = 0;
        while (curr_row < rows){
            var room_in_cols = cols - curr_col;
            if (sentence[curr_word].Length <= room_in_cols){
                // if room in row  
                curr_col = sentence[curr_word].Length + 1;
                curr_word += 1;
                if (curr_word == sentence.Length - 1){
                    count += 1;
                    curr_word = 0;
                }
            } else {
                //if no room in row
                curr_row += 1;
            }
        }
        
        return count;
    }
}
