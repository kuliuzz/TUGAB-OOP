namespace task_2;
class Program
{
    //  Да се създаде базов клас Lion, описващ лъв (Panthera leo) и производни
    // класове AfricanLion, описващ африкански лъв (Panthera leо leo) и
    // Asiatia (персийски) лъв (Panthera leo
    // persica). Класовете да съдържат информация за: тегло, ръст, латинско
    // наименование, местообитание. В класовете да се предвидят:
    //  подходящи конструктори, които инициализират стойностите на
    // полетата;
    //  подходящи свойства за връзка с полетата;
    //  подходящи методи, които въвеждат и извеждат информация за
    // животното.
    // Да се създаде демонстрационна програма за работа с класовете.
    static void Main(string[] args)
    {
        Lion random = new Lion();
        random.Height = 2;
        AfricanLion simba = new AfricanLion();
        simba.Height = 1;
        AfricanLion king = new AfricanLion(12.5, 0.76, "Nepal" );

        Console.WriteLine(random.LatinName + " " + simba.LatinName);
        Console.WriteLine(simba.LatinName + " " + random.LatinName + king.LatinName);
        
        random.getLionData();
        king.getLionData();
        
    }
    class Lion {
        protected double weight, height;
        protected string latinName, habitatLocation;

        public Lion(){
            latinName = "Panthera leo";
        }
        public Lion(double newWeight, double newHeight, string newHabitat){
            latinName = "Panthera leo";
            weight = newWeight;
            height = newHeight;
            habitatLocation = newHabitat;
        }

        public double Weight{
            set {weight = value;}
            get {return weight;}
        }
        public double Height{
            set {height = value;}
            get {return height;}
        }
        public string LatinName{
            set {latinName = value;}
            get {return latinName;}
        }
        public string HabitatLocation{
            set {habitatLocation = value;}
            get {return habitatLocation;}
        }

        public void getLionData(){
            if(weight > 0){
                Console.WriteLine("The lion is {0} species, has a weight of {1}kg and height of {2}cm", latinName, weight, height);
                Console.WriteLine("The location it can be found is {0}", habitatLocation);
            }else{
                Console.WriteLine("The lion is {0} species, no other data available", latinName);
            }
        }
    }
    class AfricanLion : Lion {
        public AfricanLion(){
            latinName = "Panthera leo leo";
        }
        public AfricanLion(double newWeight, double newHeight, string newHabitat): base( newWeight, newHeight, newHabitat){
            latinName = "Panthera leo leo";
        }

    }
    class AsiaticLion : Lion {
        public AsiaticLion(){
            latinName = "Panthera leo persica";
        }
        public AsiaticLion(double newWeight, double newHeight, string newHabitat): base( newWeight, newHeight, newHabitat){
            latinName = "Panthera leo persica";
        }

    }
}
