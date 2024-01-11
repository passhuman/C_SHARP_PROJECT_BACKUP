namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM20
{
static void Main_(string[] args)
    {
        int x = 10;
        int y = 5;

        int z1 = Plus(x, y);
        int z2 = Plus();
        int z3 = Plus(5);
        int z4 = Plus(y:10, x:-3);

        Console.WriteLine("두 수를 합한 결과는 : {0}", z1);
        Console.WriteLine("두 수를 합한 결과는 : {0}", z2);
        Console.WriteLine("두 수를 합한 결과는 : {0}", z3);
        Console.WriteLine("두 수를 합한 결과는 : {0}", z4);
    }
    static int Plus(int x=3, int y=5)
    {
        return x + y;
    }
}