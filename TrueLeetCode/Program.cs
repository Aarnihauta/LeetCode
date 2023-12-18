using TrueLeetCode.Advanced.DataStructure.LinkedLists;

var list = new DoublyLinkedList<int>();

list.InsertFirst(0);
list.InsertLast(1);
list.InsertLast(2);
list.InsertLast(3);

list.Delete(3);
list.Draw();