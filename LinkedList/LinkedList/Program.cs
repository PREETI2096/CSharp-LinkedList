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

            MyLinkedList<int> list = new MyLinkedList<int>();
            list.addFirst(node1);
            list.addFirst(node2);
            list.addFirst(node3);
            list.displayLikedList();
        }
    }
}