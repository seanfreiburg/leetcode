public class ValidWordAbbr {
    public static Dictionary<string, string> dict = new Dictionary<string, string>();
    public ValidWordAbbr(string[] dictionary) {
        for (int i = 0; i < dictionary.Length; i++){
            var key = getKey(dictionary[i]);
            if (!dict.ContainsKey(key)){
                dict.Add(key, "");
            }
            
        }
    }
    
    public bool IsUnique(string word) {
            var key = getKey(word);
            return !dict.ContainsKey(key);
    }
    
    public string getKey(string word){
            var length = word.Length;
            var count = "";
            var key = "";
            if (length == 1){
                key = word[0] + "";
            }
            else if (length == 2){
                key = word[0] + word[1] + "";
            }
            else if (length > 2){
                count = (length -2).ToString();
                key = word[0] + count + word[length -1];
            }
            return key;
    }
}
