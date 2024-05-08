namespace TrueLeetCode.Leetcode.Queue;

//https://leetcode.com/problems/relative-ranks
public class L506
{
    public string[] FindRelativeRanks(int[] score)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        string[] result = new string[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            pq.Enqueue(i, -score[i]);
        }

        if(pq.Count > 0)
        {
            result[pq.Dequeue()] = "Gold Medal";
        }
        if (pq.Count > 0)
        {
            result[pq.Dequeue()] = "Silver Medal";
        }
        if (pq.Count > 0)
        {
            result[pq.Dequeue()] = "Bronze Medal";
        }

        for(int i = 4; pq.Count > 0; i++)
        {
            result[pq.Dequeue()] = i.ToString();
        }

        return result;
    }
}
