namespace task_1;
class Program
{
    static void Main(string[] args)
    {
        Point tochkaEdno = new Point();
        Point tochkaDve = new Point();
        Point tochkaTri = new Point();
        
        tochkaEdno.setPointManually();
        tochkaDve.createPoint(1, -3);
        tochkaTri.createPoint(2, 5);

        tochkaEdno.printPoint();
        tochkaDve.printPoint();  
        tochkaTri.printPoint();  

        Point.calcDistance(tochkaEdno, tochkaDve);
        Point.calcDistance(tochkaEdno, tochkaTri);
        tochkaDve.comparePoint(tochkaTri);

    }
    class Point {
        private int x, y;

        public void setPointManually(){
            Console.Write("Въведете стойност за Х: ");
            this.x = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете стойност за У: ");
            this.y = Int32.Parse(Console.ReadLine());
        }

        public void createPoint(int newX, int newY){
            this.x = newX;
            this.y = newY;
        }

        public void printPoint(){
            Console.WriteLine("Координати за точка: Х:{0} Y:{1}", this.x, this.y);
        }

        public void comparePoint(Point a){
            int biggerX, biggerY, smallerX, smallerY;
            int distanceX = 0, distanceY = 0;
            if (a.x > this.x | this.x > a.x){
                biggerX = Math.Max(a.x, this.x);
                smallerX =  Math.Min(a.x, this.x);
                distanceX = biggerX - smallerX;
            }
            if (a.y > this.y | this.y > a.y){
                biggerY = Math.Max(a.y, this.y); 
                smallerY =  Math.Min(a.y, this.y);
                distanceY = biggerY - smallerY;
            }
            Console.WriteLine("Разстоянието между точките в Х равнина е: {0}", distanceX);
            Console.WriteLine("Разстоянието между точките в У равнина е: {0}", distanceY); 
        }

        public static void calcDistance(Point a, Point b){
             int biggerX, biggerY, smallerX, smallerY;
             int distanceX = 0, distanceY = 0;
            if (a.x > b.x | b.x > a.x){
                biggerX = Math.Max(a.x, b.x);
                smallerX =  Math.Min(a.x, b.x);
                distanceX = biggerX - smallerX;
            }
            if (a.y > b.y | b.y > a.y){
                biggerY = Math.Max(a.y, b.y); 
                smallerY =  Math.Min(a.y, b.y);
                distanceY = biggerY - smallerY;
            }

            Console.WriteLine("Разстоянието между точките в Х равнина е: {0}", distanceX);
            Console.WriteLine("Разстоянието между точките в У равнина е: {0}", distanceY);

        }


    }
}
