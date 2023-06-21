namespace task_2;
class Program
{
    // Да се декларира С# клас Car , описващ автомобил, с полета марка, цвят
    // и регистрационен номер. Класът да съдържа два конструктора без
    // параметри и с три параметъра, които инициализират стойностите на
    // полетата. Класът да съдържа свойства за четене и запис на всяко едно
    // от полетата и метод, който извежда всички данни за автомобил. Да се
    // създаде конзолно приложение за демонстрация на работата с клас Car.
    static void Main(string[] args)
    {
        Car opel = new Car();
        Car porsche = new Car("porsche", "deep blue", "EB 0911 AC");

        opel.carBrand = "Opel";
        opel.carColor = "white";
        opel.carNumber = "A 1234 KA";

        opel.getCar();
        porsche.getCar();

    }
    class Car {
        string brand, color, number;

        public Car(){}
        public Car(string newBrand, string newColor, string newNumber){
            brand = newBrand;
            color = newColor;
            number = newNumber;
        }

        public string carBrand{
            get {return brand;}
            set {brand = value;}
        }
        public string carColor{
            get {return color;}
            set {color = value;}
        }
        public string carNumber{
            get {return number;}
            set {number = value;}
        }

        public void getCar(){
            Console.WriteLine("The car brand is {0} in {1} color, with license {2}.", this.brand, this.color, this.number);
        }

    }
}
