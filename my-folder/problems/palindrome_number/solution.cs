public class Solution {
    public bool IsPalindrome(int x) {
        //updated since my last case, this should run even better due reduced iterations
        //i was on the right track by using modulo to avoid converting to string
        //this should be much improved

        // immediately return false and special cases
        //if x is negative, it cannot be palindrome according to prompt
        //also any num ending in 0 cannot be as any 0 before a num will be dropped by rational people
        //except for the number 0 on it's own
        if(x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int revertedNumber = 0;
        while(x > revertedNumber) {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }

        // Remove middle num if odd and check both halves of x
        return x == revertedNumber || x == revertedNumber/10;
}
}