namespace Stack_ot_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(array);
            int count = stack.Count + 1;
            while (stack.Count != 0)
            {
                count--;
                Console.WriteLine($"element: {count} ==> {stack.Pop()}");

            }
        }
    }
}
