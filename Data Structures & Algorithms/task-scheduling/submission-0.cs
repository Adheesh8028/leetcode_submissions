public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];

        foreach(char task in tasks){
            freq[task - 'A']++;
        }
        Array.Sort(freq);
        Array.Reverse(freq);

        int maxFreq = freq[0];
        int idleSlots = (maxFreq - 1)*n;
        for (int i = 1; i < 26 && idleSlots > 0; i++)
        {
            idleSlots -= Math.Min(maxFreq - 1, freq[i]);
        }
        idleSlots = Math.Max(0,idleSlots);
        return tasks.Length + idleSlots;
    }
}
