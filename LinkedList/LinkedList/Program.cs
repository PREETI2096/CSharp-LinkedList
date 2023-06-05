namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");

            Node<int> node1 = new Node<int>(70);
            Node<int> node2 = new Node<int>(40);
            Node<int> node3 = new Node<int>(30);
            Node<int> node4 = new Node<int>(20);

            MyLinkedList<int> list = new MyLinkedList<int>();
             list.addLast(node1);
             list.addLast(node2);
             list.addLast(node3);

            list.addAfter(node2, node4);
             list.addAfter(node3, node4);
            list.displayLikedList();
        }
    }
}