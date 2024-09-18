namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/course-schedule
public class L207
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var list = new List<List<int>>();
        var visited = new bool[numCourses];
        var recursion = new bool[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            list.Add(new List<int>());
        }

        foreach (var item in prerequisites)
        {
            var from = item[0];
            var to = item[1];

            list[from].Add(to);
        }


        for (int i = 0; i < numCourses; i++)
        {
            if (HasCycle(i, list, visited, recursion))
            {
                return false;
            }
        }

        return true;
    }

    private bool HasCycle(int v, List<List<int>> adjList, bool[] visited, bool[] recursion)
    {
        visited[v] = true;
        recursion[v] = true;

        foreach (int prerequisiteCourse in adjList[v])
        {
            if (recursion[prerequisiteCourse])
            {
                return true;
            }

            if (!visited[prerequisiteCourse] && HasCycle(prerequisiteCourse, adjList, visited, recursion))
            {
                return true;
            }
        }

        recursion[v] = false;

        return false;
    }
}
