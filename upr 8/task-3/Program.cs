namespace task_3;
class Program
{
    // Да се декларира клас Person, описващ персона с име, фамилия и
    // телефонен номер. Класът да съдържа два конструктора без параметри и
    // с три параметъра, които инициализират стойностите на полетата. Класът
    // да съдържа свойства за четене и запис на всяко едно от полетата и
    // метод, който извежда всички данни за персоната. Да се създаде
    // конзолно приложение за работата с класа.
    static void Main(string[] args)
    {
        Person b1 = new Person();
        Person b2 = new Person("Ivan", "Penchev", "0889 143 234");
        b1.FirstName = "Stoyo";
        b1.LastName = "Goshev";
        b1.Telephone = "0896 345 998";

        b1.getPerson();
        b2.getPerson();
    }
    class Person{
        string firstName, lastName, telephone;

        public Person(){

        }
        public Person(string fName, string lName, string tel){
            firstName = fName;
            lastName = lName;
            telephone = tel;
        }

        public string FirstName{
            set {firstName = value;}
            get {return firstName;}
        }
        public string LastName{
            set {lastName = value;}
            get {return lastName;}
        }
        public string Telephone{
            set {telephone = value;}
            get {return telephone;}
        }

        public void getPerson(){
            Console.WriteLine("The person's name is {0} {1} and his phone number is {2}", this.firstName, this.lastName, this.telephone);
        }
    }
}
