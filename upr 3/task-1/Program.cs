namespace task_1;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение на С#, с което се дефинира
        // едномерен масив от n реални елемента с двойна точност. Да се въведат
        // стoйности на елементите и се изведат в прав и обратен ред. Да се
        // изведат поотделно елементите с четен и нечетен индекс.
        // Упътване: Където е възможно да се използва конструкция foreach вместо
        // конструкция for

        int arrayLength;
        string inputValue;

        do {
            Console.WriteLine("Въведете брой числа за попълване");
            inputValue = Console.ReadLine();
        } while( !int.TryParse(inputValue, out arrayLength) );

        double[] arrayOfValues = new double[arrayLength];

        Console.WriteLine("Въведете цяло или дробно число"); 

        for (int i = 0; i < arrayOfValues.Length; i++)
        {
            arrayOfValues[i] = Math.Round(double.Parse(Console.ReadLine()),2);
        }

        Console.Write("Елементи в прав ред:"); 
        foreach (var item in arrayOfValues)
        {
            Console.Write(" {0},", item);
        }
        Console.WriteLine(); 

        Array.Reverse( arrayOfValues );
        Console.Write("Елементи в обратен ред:"); 
        foreach (var item in arrayOfValues)
        {
            Console.Write(" {0},", item);
        }
        Console.WriteLine(); 

        Array.Reverse( arrayOfValues );
        Console.Write("Четни Елементи:"); 
        foreach (var item in arrayOfValues)
        {
            if(item % 2 == 0) {
                Console.Write(" {0},", item);
            }
        }
        Console.WriteLine();

        Console.Write("Нечетни Елементи:"); 
        foreach (var item in arrayOfValues)
        {
            if(item % 2 != 0) {
                Console.Write(" {0},", item);
            }
        }
        
        
    }
}
