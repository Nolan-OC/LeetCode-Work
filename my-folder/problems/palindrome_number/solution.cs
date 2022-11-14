public class Solution {
    public bool IsPalindrome(int x) {
        List<int> list = new List<int>();
        if(x<0)
            return false;

//Challenged to not convert to string for comparison, 
//use modulos to check digit and division to move 
        while (x != 0) {
            list.Add(x%10);
            x /= 10;
        }
        List<int> reverse = Enumerable.Reverse(list).ToList();

//only need to check half the list.Count to check if mirrored
//any middle int's don't matter and shouldn't be checked
        for(int i = 0; i<list.Count/2; i++)
        {
            Console.WriteLine("Compare " + list[i] + " : " + reverse[i]);
            if(list[i] != reverse[i])
                return false;
        }
        return true;
    }
}