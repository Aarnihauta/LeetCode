using TrueLeetCode.Advanced.DataStructure.LinkedLists;

SinglyLinkedList list = new SinglyLinkedList(0);

list.InsertLast(1);
list.InsertLast(2);
list.InsertLast(3);
list.Draw();
list.Remove(list.Find(1));
list.Draw();