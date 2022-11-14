public class Solution {

    public int RomanToInt(string s) 
    {
        var values = new Dictionary<string,int>(){
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000}
        };

        int sum = 0;
        for(int i=0; i<s.Length; i++)
        {
            int curVal=(values[s[i].ToString()]);
            if(i<s.Length-1 && curVal<(values[s[i+1].ToString()]))
                curVal *= -1;
            sum += curVal;
        }
        return sum;
    }


}