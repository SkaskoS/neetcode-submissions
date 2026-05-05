public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set1 = new HashSet<int>();

        foreach(int i in nums) {
            if(set1.Contains(i))

            return true;

            set1.Add(i);
        }

        return false;

    }
}
