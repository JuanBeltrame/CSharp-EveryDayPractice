﻿public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    // Return the indices of the two numbers that add up to the target
                    return new int[] { i, j };
                }
            }
        }
        // If no solution is found, return an empty array or handle it as needed
        return new int[0];
    }
}
