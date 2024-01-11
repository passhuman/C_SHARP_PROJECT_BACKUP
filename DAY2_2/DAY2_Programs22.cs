namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM22
{
static void Main_(string[] args)
    {
        int x = 10;
        int y = 5;
        swap(x, y);
        Console.WriteLine("두 수를 교환한 결과는 : {0}과 {1}", x, y);
    }
    static void swap(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine("두 수를 교환한 결과는(swap함수내) : {0}과 {1}", x, y);
    }
}