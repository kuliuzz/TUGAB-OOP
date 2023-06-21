namespace task_2;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение на С#, с което се дефинира
        // едномерен масив от n целочислени елемента. Да се въведат стойности
        // на елементите и да се създаде втори масив, в който да се копират само
        // положителните елементи от първия масив. Да се изведат на екрана и
        // двата масива.

        static void printArray(Array someArray){
            foreach (var item in someArray)
            {
                Console.Write(" {0},", item);
            }
        }

        int arrayLength;
        string inputValue;

        do {
            Console.WriteLine("Въведете брой числа за попълване");
            inputValue = Console.ReadLine();
        } while( !int.TryParse(inputValue, out arrayLength) );

        int[] arrayOfValues = new int[arrayLength];

        for (int i = 0; i < arrayOfValues.Length; i++)
        {
            arrayOfValues[i] = int.Parse(Console.ReadLine());
        }

        int[] positiveValues = arrayOfValues.Where(a => a > 0).ToArray();

        Console.Write("Елементи в масива:");
        printArray(arrayOfValues);
        Console.WriteLine();
        Console.Write("Позитивни елементи в масива:");
        printArray(positiveValues);
    }
}
