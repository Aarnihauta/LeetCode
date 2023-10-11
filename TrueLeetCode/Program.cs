using TrueLeetCode.Leetcode.Graphs;

var l = new L841();

var list = new List<IList<int>>()
{
    new List<int>(){ 1, 3},
    new List<int>(){ 3,0,1},
    new List<int>(){ 2},
    new List<int>(){ 0},
};

l.CanVisitAllRooms(list);