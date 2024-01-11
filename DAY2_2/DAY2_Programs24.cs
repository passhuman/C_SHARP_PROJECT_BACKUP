namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM24
{
static void Main_(string[] args)
    {
        int x;
        int y;
        out_test(out x, out y);
        Console.WriteLine("두 수는 : {0}과 {1}", x, y);
    }
    static void out_test(out int x, out int y)
    {
        x = 30;
        y = 15;
        Console.WriteLine("두 수는(함수내) : {0}과 {1}", x, y);
    }
}