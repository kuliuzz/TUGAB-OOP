namespace taskEight;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("въведете число за височина на коледната елха");
        int num = Int32.Parse(Console.ReadLine());

        void printTree() {
            for (int i = 0; i <= num; i++)
            {
                for (int k = num; k >= 0; k--)
                {
                    if(k <= i){
                        Console.Write(k);
                    }else{
                        Console.Write(" ");
                    }
                }
                
                for (int g = 1; g <= num; g++)
                {
                    if(g > i){
                        Console.Write(' ');
                    }else{
                        Console.Write(g);
                    }
                }
 
                Console.WriteLine();
            }
        }
        printTree();
    }
}
