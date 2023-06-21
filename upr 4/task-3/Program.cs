namespace task_3;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение на С#, с което се декларира клас,
        // описващ студент с трите имена, факултетен номер и специалност.
        // Класът да съдържа методи за въвеждане и извеждане стойностите на
        // полетата и метод, който отпечатва на екрана имената на студент по
        // въведен факултетен номер. Да се създаде демонстрационна програма за
        // работа с класа.

        Student ivancho = new Student();
        ivancho.StudenNames = "Ivan Petkanov Kolev";
        ivancho.StudenSpeciality ="Biology";
        ivancho.StudenNumber = 123456789;

        Console.WriteLine(ivancho.StudenNames);
        Console.WriteLine(ivancho.StudenSpeciality);
        
        ivancho.getDataByNumber(1);
        ivancho.getDataByNumber(123456789);

    }
    class Student {
        private string threeNames, speciality;
        private int facNum;

        public string StudenNames
        {
            get { return threeNames; }
            set { threeNames = value; }
        }
        public string StudenSpeciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public int StudenNumber
        {
            get { return facNum; }
            set { facNum = value; }
        }
        public void getDataByNumber(int number){
            if(number == this.facNum){
                Console.WriteLine("Student {0} stydies {1}", this.threeNames, this.speciality);
            }else{
                Console.WriteLine("No Student exists with the provided number");
            }
        }

    }
}
