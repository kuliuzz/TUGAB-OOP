namespace task_2;
class Program
{
    static void Main(string[] args)
    {
        Convert.MeterToKilometer(5.5);
        Convert.KilometerToMeter(19.9);

    }
//метър в секунда в километри в час
    class Convert{
        public static void MeterToKilometer(double a){
            double result = (a * 3600) / 1000;
            Console.WriteLine("Стойността е равна на {0} километра в час", Math.Round(result,1));
        }
        public static void KilometerToMeter(double a){
            double result = (a * 1000) / 3600;
            Console.WriteLine("Стойността е равна на {0} метра в секунда", Math.Round(result,1));
        }

    }
}
