public class Solution {
    public void Rotate(int[] nums, int k) 
    {
        int tmp = nums.Count();
        var nums2 = (int[])nums.Clone();
        for(int i = 0; i < nums.Count(); i++)
        {
            nums[((i+k)%(tmp))] = nums2[i];
        }
    }
}
