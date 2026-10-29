public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxHeap = new();

        foreach(int stone in stones){
            maxHeap.Enqueue(stone,-stone);
        }
        while(maxHeap.Count > 1){
        int first = maxHeap.Dequeue();
        int second = maxHeap.Dequeue();
         if(first != second){
         int remaining = first - second;
         maxHeap.Enqueue(remaining, -remaining);
         }
        }
        return maxHeap.Count == 0? 0 : maxHeap.Dequeue();
    }
}
