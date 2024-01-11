namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM23
{
static void Main_(string[] args)
    {
        int x = 10;
        int y = 5;
        swap(ref x, ref y);
        Console.WriteLine("두 수를 교환한 결과는 : {0}과 {1}", x, y);
    }
    static void swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine("두 수를 교한한 결과는(swap함수내) : {0}과 {1}", x, y);
    }
}