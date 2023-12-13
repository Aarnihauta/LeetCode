using TrueLeetCode.Advanced.DataStructure.LinkedLists;

SinglyLinkedList list = new SinglyLinkedList(0);

list.InsertLast(1);
list.InsertLast(2);
list.InsertLast(3);

var c = list.Find(2);
list.Insert(c, 14);
list.Draw();