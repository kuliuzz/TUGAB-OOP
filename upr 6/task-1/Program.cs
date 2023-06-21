namespace task_1;
class Program
{
    // Да се декларира клас Dog, описващ куче с полета за име на кучето и възраст. Класът да
    // съдържа метод, които въвежда стойности за полетата от клавиатурата и метод, който дава
    // информация за кучето. Да се добави метод с два параметъра, които инициализират
    // стойностите на полетата. Да се създаде програма, която демонстрира работата с обекти от
    // класа като се дефинират най-малко три обекта от клас Dog.
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        Dog dog3 = new Dog();

        dog1.writeNameAndAge();
        dog2.setNameAndAge(3, "Балкан");
        dog3.setNameAndAge(1, "Петкан");

        dog1.getDogParams();
        dog2.getDogParams();
        dog3.getDogParams();

    }
    class Dog {
        int age;
        string name;

        public void writeNameAndAge(){
            Console.WriteLine("Въведете последователно име и възраст на кучето");
            this.age = Int16.Parse(Console.ReadLine());
            this.name =Console.ReadLine();
        }

        public void setNameAndAge(int dogAge, string dogName){
            this.age = dogAge;
            this.name = dogName;
        }

        public void getDogParams(){
            Console.WriteLine("Кучето {0} e на възраст {1}", this.age, this.name);
        }
    }
}

