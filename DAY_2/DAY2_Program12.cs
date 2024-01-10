namespace c_SHARP_PROJECT;
public class DAY2_PROGRAM12
{
static void Main(String []args)
    {
        int[] reading = new int[] {4, 6, 11, 55, 34, 9, 12, 2, 1, 32};
        Console.WriteLine("차원={0}, 길이={1}", reading.Rank, reading.Length);

        Console.WriteLine("배열의 최소 값: {0}", reading.Min());
        Console.WriteLine("배열의 최대 값: {0}", reading.Max());
        Console.WriteLine("먹고 남은 빵의 전체 개수는 {0}개", reading.Sum() - reading.Min()-reading.Max());
    }
}