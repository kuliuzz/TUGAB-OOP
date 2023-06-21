namespace taskSix;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("въвеждайте числа за да бъдат сумирани, натиснете 0 за изход");
        
        void sumConsoleNumbers() {
            int summ = 0;
            int num;
            do
            {
                num = Int32.Parse(Console.ReadLine());
                summ += num;
            } while (num != 0);

            Console.WriteLine(summ);
        }

        sumConsoleNumbers();
    }
}
