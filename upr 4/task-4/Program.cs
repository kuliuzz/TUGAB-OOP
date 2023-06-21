namespace task_4;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение на С#, с което се декларират
        // класове описващи точка (Point) и правоъгълна област (Rectangle),
        // описана чрез координатите на горния ляв ъгъл и размерите на областта.
        // Класовете да съдържат методи за въвеждане и извеждане стойностите
        // на полетата. Клас Rectangle да съдържа метод, които определя дали
        // дадена точка попада в областта. Да се създаде демонстрационна
        // програма за работа с класовете.
        Point A = new Point();
        A.X = -2;
        A.Y = -3;
        A.getLocation();


        Point B = new Point();
        B.X = -3;
        B.Y = -2;

        Rectangle Rect = new Rectangle();
        Rect.X = -2;
        Rect.Y = -2;
        Rect.xLen = 2;
        Rect.yLen = 2;
        Rect.getStartLocation();
        Rect.getTotalArea();
        Rect.checkIfPointInRectangle(A);
        Rect.checkIfPointInRectangle(B);

    }
    class Point {
        private int x, y = 0;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void getLocation(){
            Console.WriteLine("Point coordinates at x:{0}, y:{1}", this.X, this.y);
        }
    }
    class Rectangle {
        private int x, y, xLength, yLength = 0;            
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        } 
        public int xLen
        {
            get { return xLength; }
            set { xLength = value; }
        } 
        public int yLen
        {
            get { return yLength; }
            set { yLength = value; }
        } 

        public void getStartLocation(){
            Console.WriteLine("Rectangle starts at point x:{0}, y:{1}", this.X, this.y);
        }
        public void getTotalArea(){
            Console.Write("Rectangle area starts at x:{0}, y:{1} (upper left corner) ", this.X, this.y);
            Console.WriteLine("and ends at x:{0}, y:{1}  (lower right corner)", this.X + this.xLength, this.y - this.yLength );
        }

        public void checkIfPointInRectangle(Point point){
            if(point.X <= this.X + this.xLength && point.X >= this.X ){
                if(point.Y <= this.Y && point.Y >= this.Y - this.yLength ){
                    Console.WriteLine("Point is in Rectangle's'boundaries");
                }else{
                    Console.WriteLine("Point is NOT in Rectangle's'boundaries");
                }
            }
            else{
                Console.WriteLine("Point is NOT in Rectangle's'boundaries");
            }
        }
    }
}
