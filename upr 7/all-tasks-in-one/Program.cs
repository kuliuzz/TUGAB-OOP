namespace all_tasks_in_one;

class Program
{
    static void Main(string[] args)
    {
        Time initialTime = new Time();
        initialTime.getTime();
        Time newTime = new Time(12, 22, 41);
        newTime.getTime();

        Square instanceSuare = new Square(1.5);
        instanceSuare.getArea();

        Rectangle instanceRect = new Rectangle(1.5, 5);
        instanceRect.getArea();

        Circle instanceCircle = new Circle(2.5);
        instanceCircle.getArea();

        Student defaulstStudent = new Student();
        defaulstStudent.getStudentData();

        Student Pesho = new Student("Pesho","Ivanov","Stoev");
        Pesho.getStudentData();

        Student Ivan = new Student(121555321, 2, "Astronomy");
        Ivan.getStudentData();

        Student Anton = new Student("Anton", "Semov","Georgiev", "Elektronics", 33471215, 4);
        Anton.getStudentData();
    }
}

class Time
{
    int hour, minute, second;

    public Time() {
        hour = 00;
        minute = 00;
        second = 00;
    }
    public Time(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }
    public void getTime()
    {
        Console.WriteLine("The time is {0}:{1}:{2}", this.hour, this.minute, this.second);
    }
}

class Rectangle
{
    double sideOne, sideTwo;
    public Rectangle()
    {
        sideOne = 1;
        sideTwo = 2;
    }
    public Rectangle(double sideOne, double sideTwo )
    {
        this.sideOne = sideOne;
        this.sideTwo = sideTwo;

    }
    public void getArea()
    {
        Console.WriteLine("The area of the rectangle is: {0}", this.sideOne * this.sideTwo);
    }
}
class Circle
{
    double radius;
    public Circle()
    {
        radius = 1;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void getArea()
    {
        Console.WriteLine("The area of the circle is: {0}", Math.Round(Math.PI * (this.radius * 2), 2));
    }
}
class Square
{
    double side;
    public Square()
    {
        side = 1;
    }
    public Square(double side)
    {
        this.side = side;
    }
    public void getArea()
    {
        Console.WriteLine("The area of the square is: {0}", this.side * this.side);
    }
}
class Student
{
    string firstName, sirName, lastName, speciality;
    int fakNum, courseYear;

    public Student()
    {
        firstName = "No name";
        sirName = "No name";
        lastName = "No name";
        fakNum = 00000000;
        courseYear = 0;
        speciality = "No data";
    }
    public Student(string firstName, string sirName, string lastName)
    {
        this.firstName = firstName;
        this.sirName = sirName;
        this.lastName = lastName;
    }
    public Student(string firstName, string sirName, string lastName, string  speciality)
    {
        this.firstName = firstName;
        this.sirName = sirName;
        this.lastName = lastName;
        this.speciality = speciality;
    }
    public Student(int fakNum, int courseYear, string speciality)
    {
        this.fakNum  = fakNum;
        this.courseYear = courseYear;
        this.speciality = speciality;
    }
    public Student(
        string firstName, 
        string sirName, 
        string lastName, 
        string speciality, 
        int fakNum, 
        int courseYear
        ){
        this.firstName = firstName;
        this.sirName = sirName;
        this.lastName = lastName;
        this.speciality = speciality;
        this.fakNum = fakNum;
        this.courseYear = courseYear;
    }
    public void getStudentData()
    {
        Console.WriteLine("Student with names: {0} {1} {2}", this.firstName, this.sirName, this.lastName);
        Console.WriteLine("Student studies {0} in his {1} year, with faculty number: {2}", this.speciality, this.courseYear, this.fakNum);
        Console.WriteLine("---------------------------------------------------");

    }
}

