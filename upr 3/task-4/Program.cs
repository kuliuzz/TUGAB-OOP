namespace task_4;
class Program
{
    static void Main(string[] args)
    {
        // Да се създаде конзолно приложение, с което се обработват следните
        // метереологични данни: измерени са температури в дадени станции и се
        // извлича следната информация – в коя станция е измерена най-висока и в
        // коя най-ниска температура; каква е температурната разлика между двете
        // температури. Да се отчита и факта, че в повече от една станции може да
        // е измерена еднаква температура.

        int[] meteoData = {19,-1,33,25,29,19,35,-1,33};
        string[] meteoStations = {
            "Ново село",
            "Видин",
            "Лом",
            "Оряхово",
            "Монтана",
            "Враца",
            "Кнежа",
            "Ловеч",
            "Плевен"
        };
        int lowestTemp, highestTemp, idx;

        int[] clonedTemps = new int[meteoData.Length]; 
        Array.Copy(meteoData, 0, clonedTemps, 0, meteoData.Length -1);
        Array.Sort(clonedTemps);
        lowestTemp = clonedTemps[0];
        highestTemp = clonedTemps[clonedTemps.Length -1];

        List<int> lowList = new List<int>();
        List<int> highList = new List<int>();

        for (int a = 0; a < meteoData.Length; a++)
        {
            if(meteoData[a]== lowestTemp){
                lowList.Add(a);
            }
            if(meteoData[a]== highestTemp){
                highList.Add(a);
            }
        }

        int[] lowIndexes = lowList.ToArray();
        int[] highIndexes = highList.ToArray();

        Console.Write("Най-ниска измерена температура: {0}, станции: ",lowestTemp);
        for (int i = 0; i < lowIndexes.Length; i++)
        {
            Console.Write(" {0},", meteoStations[lowIndexes[i]]);
        }
        Console.WriteLine();
        Console.Write("Най-висока измерена температура:  {0}, станции: ",highestTemp);
        for (int i = 0; i < highIndexes.Length; i++)
        {
            Console.Write(" {0},", meteoStations[highIndexes[i]]);
        }
        Console.WriteLine();
        Console.Write("Температурна разлика: {0}", highestTemp - lowestTemp);
    }
}
