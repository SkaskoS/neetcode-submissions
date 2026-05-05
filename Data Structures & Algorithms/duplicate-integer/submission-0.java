class Solution {

    public boolean hasDuplicate(int[] nums) {
        Set<Integer> tar = new HashSet<>();

        for(int i = 0; i < nums.length; i++) {
            if(tar.contains(nums[i])) {
                return true;
            } 
            tar.add(nums[i]);
        }
        return false;
    }
}
