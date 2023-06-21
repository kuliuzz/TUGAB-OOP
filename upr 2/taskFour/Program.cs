namespace taskFour;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("въведете число ");
        int num = Int32.Parse(Console.ReadLine());

        void iterateToNum() {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            for (int i = num; i >= 1; i--)
            {
                Console.Write(i+ " ");
            }
        }

        iterateToNum();
    }
}
