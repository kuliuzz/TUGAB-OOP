namespace task_1;
class Program
{
    static void Main(string[] args)
    {
        House a = new House(1,72,"Vitosha 5","Ivan Tilev", 4);
        a.Height = 4;
        a.getInfo();
        House b = new House(2.5,145.67,"Freedom str. 4","John Snow", 10);
        b.Owner = "Gandalf";
        b.getInfo();
    }
    class Building {
        protected double height, area;
        protected string address;

        public Building(double h, double a, string location){
            height = h;
            area = a;
            address = location;
        }

        public double Height{
            set {height = value;}
            get {return height;}
        }

        public double Area{
            set {area = value;}
            get {return area;}
        }
        public string Address{
            set {address = value;}
            get {return address;}
        }

        public void getInfo (){
            Console.WriteLine("The Building is {0} meters high, has build area of {1} and is located at {2}", height, area, address);
        }
    }
    class House : Building {
        string ownerName;
        int floorCount;
        public House(double h, double a, string location, string owner, int floors):base(h, a, location){
            ownerName = owner;
            floorCount = floors;
        }

        public string Owner{
            set {ownerName = value;}
            get {return ownerName;}
        }
        public int Floors{
            set {floorCount = value;}
            get {return floorCount;}
        }

        public void getInfo (){
            Console.WriteLine("The Building is {0} meters high, with {1} floors, has build area of {2} and is located at {3}", height,floorCount, area, address);
            Console.WriteLine("The owner's name is {0}", ownerName);

        }

    }
}

