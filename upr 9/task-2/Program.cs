namespace task_2;
class Program
{
    // Да се дефинира клас Person, описващ лични данни на персона: имена,
    // ЕГН, лична карта и производен клас Student, описващ студент с данни –
    // специалност, група, факултетен номер. Класовете да съдържат методи
    // за въвеждане и извеждане стойностите на полетата.
    static void Main(string[] args)
    {
        Student Ivan = new Student();
        Ivan.setData("Ivan", "123", "444", "futbol", "1", "321");
        Ivan.getData();
    }
    class Person {
        protected string names, egn, lkn;

        public void setData(string newNames, string newEgn, string newLkn){
            names = newNames;
            egn = newEgn;
            lkn = newLkn;
        }
        public void getData(){
            Console.WriteLine("Person name is {0}, EGN is {1}, Personal ID number is {2}", names, egn, lkn);
        }
    }
    class Student : Person {
         string speciality, group, fakNum;
        public void setData(string newNames, string newEgn, string newLkn, string newSpeciality, string newGroup, string facultyNum){
            names = newNames;
            egn = newEgn;
            lkn = newLkn;
            speciality = newSpeciality;
            group = newGroup;
            fakNum = facultyNum;
        }
        public void getData(){
            Console.WriteLine("Student name is {0}, EGN is {1}, Personal ID number is {2}", names, egn, lkn);
            Console.WriteLine("Student studies {0}, in group {1} and has faculty number: {2}", speciality, group, fakNum);

        }
    }
}
