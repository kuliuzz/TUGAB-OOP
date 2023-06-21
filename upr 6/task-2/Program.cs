namespace task_2;
class Program
{
    // Да се декларира клас Person, описващ персона с лични данни три имена и година на
    // раждане. Класът да съдържа: метод за въвеждане стойности на полетата от клавиатурата;
    // метод с един параметър, съответстващ на текуща година, който връща като резултат на
    // каква възраст е (или ще навърши) персоната през съответната година; метод, който дава
    // информация за персоната. Да се създаде програма, която демонстрира работата с обекти
    // от класа като се дефинират най-малко три обекта от клас Person.
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Person p2 = new Person();
        Person p3 = new Person();

        p1.setPerson();
        p2.setPerson();
        p3.setPerson();

        p1.compareYear(2030);
        p2.compareYear(2023);
        p3.compareYear(2022);
    }
    class Person {
        int age, curYear = 2023;
        string names;

        public void setPerson(){
            Console.WriteLine("Въведете трите имена на човека");
            this.names = Console.ReadLine();
            Console.WriteLine("Въведете число за възраст на човека");
            this.age = Int16.Parse(Console.ReadLine());
        }

        public void compareYear(int year){
            if(year < curYear){
                Console.WriteLine("Годината е по малка от сегашната");
            }
            else{
                int futureAge = age + (year - curYear);
                Console.WriteLine("През дадената година, човекът ще бъде на {0} години", futureAge);
            }
        }

    }
}
