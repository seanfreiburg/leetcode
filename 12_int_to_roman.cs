public class Solution {
    public string IntToRoman(int num) {
        var str = "";
        while (num >= 1000){
            str += "M";
            num = num - 1000;
        }
        while (num >= 900){
            str += "CM";
            num = num - 900;
        }
        while (num >= 500){
            str += "D";
            num = num - 500;
        }
        while (num >= 400){
            str += "CD";
            num = num - 400;
        }
        while (num >= 100){
            str += "C";
            num = num - 100;
        }
        while (num >= 90){
            str += "XC";
            num = num - 90;
        }
        while (num >= 50){
            str += "L";
            num = num - 50;
        }
        while (num >= 40){
            str += "XL";
            num = num - 40;
        }
        while (num >= 10){
            str += "X";
            num = num - 10;
        }
        while (num >= 9){
            str += "IX";
            num = num - 9;
        }
        while (num >= 5){
            str += "V";
            num = num - 5;
        }
        while (num >= 4){
            str += "IV";
            num = num - 4;
        }
        while (num >= 1){
            str += "I";
            num = num - 1;
        }
        
        return str;
    }
}
