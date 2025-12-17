public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxDiagonal=0;
        int maxArea=0;
        foreach(var rect in dimensions)
        {
            int length=rect[0];
            int width=rect[1];
            int diagonal=length*length+width*width;
            int area=length*width;
            if(diagonal>maxDiagonal)
            {
                maxDiagonal=diagonal;
                maxArea=area;
            }
            if(diagonal==maxDiagonal)
            {
               
                maxArea=Math.Max(maxArea,area);
            }

        }
        return maxArea;
    }
}