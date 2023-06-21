namespace taskFive;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("въведете число за пресмятане на факториел");
        int num = Int32.Parse(Console.ReadLine());

        void toFactoriel() {
            int fac = num;
            for (int i = num -1 ; i > 0; i--)
            {
                fac = i * fac ;
            }
            Console.WriteLine(fac);
        }

        toFactoriel();
    }
}
