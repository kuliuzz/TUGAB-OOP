namespace taskSeven;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("въведете първо число за височина на фигурите и второ за ширина на паралелепипед");
        string[] input = Console.ReadLine().Split();
        int height = Int32.Parse(input[0]);
        int width = Int32.Parse(input[1]);

        void printFigures() {
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < height; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("  ");
                for (int k = 0; k < width; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("  ");
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        printFigures();
    }
}
