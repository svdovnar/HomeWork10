using System;
using ClassLibrary;


namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyItem item = new MyItem() { Item = "pan" };
            MyItem item1 = new MyItem() { Item = "knife" };
            MyItem item2 = new MyItem() { Item = "spoon" };
            MyItem item3 = new MyItem() { Item = "fork" };
            MyItem item4 = new MyItem() { Item = "fork" };
            MyItem item5 = new MyItem() { Item = "pot" };

            MyList itemsList = new MyList();
            itemsList.Add(item);
            itemsList.Add(item1);
            itemsList.Add(item2);
            itemsList.Add(item3);
            itemsList.Add(item4);
            itemsList.Add(item5);
            Console.WriteLine($"Number of items in the list: {itemsList.Count}");
            Console.WriteLine();

            itemsList.RemoveAt(0);
            Console.WriteLine($"Number of items in the list now: {itemsList.Count}");
            Console.WriteLine($"Now first item is: {itemsList[0]}");
            Console.WriteLine();

            itemsList.Insert(0, item);
            Console.WriteLine($"First item is {itemsList[0]} again");
            Console.WriteLine($"Number of items in the list: {itemsList.Count}");
            Console.WriteLine();

            Console.WriteLine($"Index of pot is: { itemsList.IndexOf(item5)}");
            Console.WriteLine();

            itemsList.Clear();
            
            Console.ReadKey();
        }
    }
}
