namespace taskThree;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задача за изчисляване корените на квадратно уравнение");
        Console.WriteLine("задайте стойност за 'а'");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("задайте стойност за 'b'");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("задайте стойност за 'c'");
        double c = Double.Parse(Console.ReadLine());

        Console.WriteLine(a+b+c);

        void calcMultiplyers(){
            double x1 = (-b + Math.Sqrt((Math.Pow(b,2) - 4*a*c))) /2*a;
            double x2 = (-b - Math.Sqrt((Math.Pow(b,2) - 4*a*c))) /2*a;
            Console.WriteLine("корен 1: "+ x1.ToString());
            Console.WriteLine("корен 2: "+ x2.ToString());

        }
        calcMultiplyers();
    }
}
