namespace task_1;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение, с което се декларират класове
        // описващи следните фигури: правоъгълник, триъгълник и кръг. Всеки един
        // от тези класове да съдържа методи за въвеждане стойностите на
        // полетата, извеждане стойностите на полетата и намиране лицето на
        // фигурата. Да се създаде демонстрационна програма, с която се
        // дефинират обекти от класовете и се намират лицата на фигурите.
        
        Rectangle testRect = new Rectangle();
        Console.WriteLine("Въведете последователно стойности за страните на правоъгълник");
        testRect.A = Double.Parse(Console.ReadLine());
        testRect.B = Double.Parse(Console.ReadLine());
        Console.WriteLine("Страните на правоъгълника са: А:{0}, B:{1}", testRect.A,  testRect.B);
        Console.WriteLine("Лицето на правоъгълника е: {0}", testRect.getArea());

        Triangle testTriangle = new Triangle();
        Console.WriteLine("Въведете последователно стойности за дължината на страните на триъгълник");
        testTriangle.setA = Double.Parse(Console.ReadLine());
        testTriangle.setB = Double.Parse(Console.ReadLine());
        testTriangle.setC = Double.Parse(Console.ReadLine());
        Console.WriteLine("Страните на триъгълника са: А:{0}, B:{1}, C:{2}", testTriangle.setA,  testTriangle.setB,  testTriangle.setC);
        Console.WriteLine("Лицето на триъгълника е: {0}", testTriangle.getArea());

        Circle testCircle = new Circle();
        Console.WriteLine("Въведете стойност за дължината на радиуса на окръжност");
        testCircle.setRadius = Double.Parse(Console.ReadLine());

        Console.WriteLine("Лицето на окръжността е: {0}", testTriangle.getArea());

    }
    class Rectangle {
        private double sideA, sideB = 1; //set default to 1

        public double A
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double B
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double getArea() {
            return Math.Round(this.sideA * this.sideB, 2) ;
        }

    }
    class Triangle {
        private double sideA, sideB, sideC = 1; //set default to 1

        public double setA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double setB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double setC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        public double getArea() {
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));

            return Math.Round(area, 2) ;
        }
    }
    class Circle {
        private double radius = 1;
        public double setRadius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double getArea() {
            double area = Math.Pow(radius, 2) * Math.PI;

            return Math.Round(area, 2) ;
        }
    }
}
