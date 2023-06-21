namespace task_1;
class Program
{
    // Да се създаде йерархия от класове, описващи окръжност, кръгов конус и
    // цилиндър. Всеки един от класовете да съдържа конструктор (по
    // подразбиране) за инициализация стойностите на полетата. Класът,
    // описващ окръжност да съдържа метод за пресмятане лице на кръг, а
    // класовете описващи цилиндър и конус – методи за пресмятане обема на
    // фигурите. Да се създаде демонстрационна програма за работа с тези
    // класове. (да се дефинират обекти от класовете като се използват и двата
    // конструктора).
    static void Main(string[] args)
    {
        Circle k = new Circle();
        k.calclArea();
        Circle k1 = new Circle(2);
        k1.calclArea();
        Console.WriteLine("Circle's area is {0}", k.calclArea());
        Console.WriteLine("Circle's area is {0}", k1.calclArea());

        Conus ko = new Conus();
        ko.calcVolume();
        Conus ko1 = new Conus(2,1);
        ko1.calcVolume();

        Cylinder cy = new Cylinder();
        cy.calcVolume();
        Cylinder cy1 = new Cylinder(4,2);
        cy1.calcVolume();

    }

    class Circle{
        int a;

        public Circle(){
            a = 1;
        }
        public Circle(int radius){
            a = radius;
        }

        public double calclArea(){
            double area = a * 2 * Math.PI;
            return Math.Round(area,2);
        }

    }
    class Conus : Circle{
        protected int height;

        public Conus():base(){
            height = 1;
        }
        public Conus(int radius, int newHeight):base(radius){
            height = newHeight;
        }
        public void calcVolume(){
            double volume = 0.33 * this.calclArea() * height;
            Console.WriteLine("Conus volume is {0}", Math.Round(volume,2)); 
        }

    }
    class Cylinder : Conus{

        public Cylinder():base(){}
        public Cylinder(int radius, int height):base(radius, height){}

        public void calcVolume(){
            double volume = this.calclArea() * height;
            Console.WriteLine("Cylinder volume is {0}", Math.Round(volume,2)); 
        }
    }
}
