public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(var i1 = 0; i1 < nums.Length; i1++){
            if(i1 == nums.Length - 1){
                return new int[] { -1, -1 };        
            }
            int remainder = target;
            int current = nums[i1];
            remainder -= current;

            for(var i2 = i1+1; i2 < nums.Length; i2++){
                if(nums[i2] == remainder){
                    return new int[] { i1, i2 };
                }
            }
        }

        return new int[] { -1, -1 };
    }
}
