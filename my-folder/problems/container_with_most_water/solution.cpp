class Solution {
public:
//purpose is to calculate the maximum volume of water that can be held if we think of the ints in the array are the "walls" of the liquid, so which two ints give the largest area?
//For this we will iterate through the array from the beginning and the end simultaneously
//Time = BigO(N)
//Space = BigO(1)
    int maxArea(vector<int>& height) {
        int leftIndex = 0;
        int rightIndex = height.size() - 1;
        int maxVol = 0;
        //when the index's meet we stop
        while(leftIndex < rightIndex){
            int w = rightIndex - leftIndex;
            int h = min(height[leftIndex], height[rightIndex]);
            int area = h * w;
            maxVol = max(maxVol, area);
            //we move the left index here because the smaller "wall" is not important, we want to find the highest walls the furthest apart for volume = width * height
            if(height[leftIndex] < height[rightIndex]) 
                leftIndex++;
            //opposite of above
            else if(height[leftIndex] > height[rightIndex]) 
                rightIndex--;
            else {
                leftIndex++;
                rightIndex--;
            }
        }
        return maxVol;
    }
};