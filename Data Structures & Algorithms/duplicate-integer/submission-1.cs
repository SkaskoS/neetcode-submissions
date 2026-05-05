public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> test = new HashSet<int>();

        foreach(int i in nums) {
            if(test.Contains(i)) 
            return true;
            test.Add(i);
        }

        return false;
        
    }
}
