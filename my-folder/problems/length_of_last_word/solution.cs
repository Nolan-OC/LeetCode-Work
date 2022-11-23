public class Solution {
    public int LengthOfLastWord(string s) {
        //sort string into array of words, removing spaces and any whitespace on end
        s = s.TrimEnd();
        s = RemoveExtraSpaces(s);
        //remove extra spaces inbetween words
        string[] wordArr = s.Split(' ').Select(str => str.Trim()).ToArray();

        //return the last element of the array's length
        return wordArr[wordArr.Length-1].Length;
    }

    public string RemoveExtraSpaces(string str)
    {
        string returnStr = "";
        for(int i = 0; i<str.Length; i++)
        {
            if(str[i] == ' ' && i != 0)
                if(str[i-1] != ' ')
                    returnStr += str[i];     
            if(str[i] != ' ')
            {
                returnStr += str[i];
            }
        }
        return returnStr;
    }
}