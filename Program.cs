namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            
            for(int i=0; i< 10; i++)
            {
                list.Add(i);
            }

            list.Print();
        }
    }
}