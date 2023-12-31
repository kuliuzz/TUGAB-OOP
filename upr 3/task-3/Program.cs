﻿namespace task_3;
class Program
{
    static void Main(string[] args)
    {
        // Да се дефинира двумерен масив от имената на месеците и броя на
        // дните във всеки месец. Да се изведе информация всеки месец какъв
        // брой дни има.
        // Упътване: Да се използват масиви от тип string. Информацията за броя на
        // дните да е представена като низове, а не като числови стойности.

        static void printArray(Array someArray){
            foreach (var item in someArray)
            {
                Console.Write(" {0},", item);
            }
        }

        string[,] monthsData = { 
            {"Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември"}, 
            {
                "Тридесет и един",
                "Двадесет и осем",
                "Тридесет и един",
                "Тридесет",
                "Тридесет и един",
                "Тридесет",
                "Тридесет и един",
                "Тридесет и един",
                "Тридесет",
                "Тридесет и един",
                "Тридесет",
                "Тридесет и един",
            } 
        };

        for (int i = 0; i < monthsData.GetLength(1); i++)
        {
            Console.WriteLine("Месец {0} е с {1} дни.", monthsData[0,i], monthsData[1,i]);
        }
    }
}
