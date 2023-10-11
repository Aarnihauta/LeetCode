namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/keys-and-rooms/
public class L841
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        if (rooms[0].Count == 1 && rooms.Count == 1)
        {
            return true;
        }

        var toOpenRooms = new Stack<int>();
        bool[] visitedRooms = new bool[rooms.Count];

        for (int i = 0; i < rooms[0].Count; i++)
        {
            toOpenRooms.Push(rooms[0][i]);
        }

        visitedRooms[0] = true;

        while (toOpenRooms.Any())
        {
            var nextRoom = toOpenRooms.Pop();
            var keys = rooms[nextRoom];

            foreach (var item in keys)
            {
                if (visitedRooms[item] != true)
                {
                    toOpenRooms.Push(item);
                }
            }

            visitedRooms[nextRoom] = true;
        }

        var any = visitedRooms.Any(x => x == false);
        return !any;
    }
}
