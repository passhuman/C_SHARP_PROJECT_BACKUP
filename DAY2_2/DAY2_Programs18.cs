namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM18
{
static int Plus(int x, int y)
    {
        return x + y;
    }
static void Main_(string[] args)
    {
        int x = 10;
        int y = 5;

        int z = Plus(x, y);
        Console.WriteLine("두 수를 합한 결과는 : {0}", z);
        Console.WriteLine("두 수를 합한 결과는 : {0}", Plus(x, y));
    }
}
