namespace task_1;
class Program
{
    // Да се декларира С# клас, описващ правоъгълник с височина и ширина.
    // Класът да съдържа конструктор с 2 параметъра, които дават стойности
    // на полетата; конструктор с параметри, който нулират стойностите на
    // полетата; свойства само за запис, които променят стойностите на
    // полетата и свойство за четене Area, което връща площта на
    // правоъгълника. Да се създаде конзолно приложение, чрез което се
    // дефинират три обекта от клас Rectangle, задават се размери на всеки
    // един от тях и се намира кой от правоъгълниците е с най-голяма площ
    static void Main(string[] args)
    {
        Rectangle one = new Rectangle();
        Rectangle two = new Rectangle();
        Rectangle three = new Rectangle(4.5, 2);

        one.seHeight = 5;
        one.setWidth = 10;

        two.seHeight = 1.5;
        two.setWidth = 2.1;

        double biggestRect = Math.Max(one.Area , Math.Max(two.Area, three.Area));

        Console.WriteLine("Biggest area is {0}", biggestRect);

    }
    class Rectangle{
        double width, height;

        public Rectangle(){
            width = 0;
            height = 0;
        }

        public Rectangle(double newWidth, double newHeight){
            width = newWidth;
            height = newHeight;
        }

        public double setWidth{
            set {width = value;}
        }

        public double seHeight{
            set {height = value;}
        }

        public double Area{
            get { return Math.Round(width * height, 3) ;}
        }


    }
}
