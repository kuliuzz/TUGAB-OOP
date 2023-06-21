namespace labTwoo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("vuedete stoinost za strana A");
        double sideA = Double.Parse(Console.ReadLine());
        Console.WriteLine("vuedete stoinost za strana B");
        double sideB = Double.Parse(Console.ReadLine());
        Console.WriteLine("vuedete stoinost za strana C");
        double sideC = Double.Parse(Console.ReadLine());

        string defineTriangle() {
            string triangleType = "d";
            
            if(sideA == sideB && sideB == sideC){
                triangleType = "ravnostranen"; 
            }
            if(sideA != sideB ){
                if(sideB != sideC && sideA != sideC){
                   triangleType = "raznostranen"; 
                }else{
                    triangleType = "ravnobedren";
                }
            }
            return triangleType;
        }

        string result = defineTriangle();
        Console.WriteLine(result);
    }
}
