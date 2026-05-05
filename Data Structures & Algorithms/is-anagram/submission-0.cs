public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        int[] count = new int[26];

        int i = 0;

        while (i < s.Length)
        {
            count[s[i] - 'a']++; // add from s
            count[t[i] - 'a']--; // subtract from t
            i++;
        }

        // check if all zero
        foreach (int c in count)
        {
            if (c != 0) return false;
        }

        return true;
    }
}