// See https://aka.ms/new-console-template for more information
using Day3;


MyList<int> l1 = new MyList<int>(10);

l1.Add(1);
l1.Add(2);
l1.Add(3);
l1.Add(4);
l1.Add(5);
l1.Add(6);



l1.InsertAt(10, 4);
l1.InsertAt(7, 3);
l1.InsertAt(8, 9);

Console.WriteLine("Before delete");
l1.printList();

l1.DeleteAt(3);
Console.WriteLine("after delete");
l1.printList();
