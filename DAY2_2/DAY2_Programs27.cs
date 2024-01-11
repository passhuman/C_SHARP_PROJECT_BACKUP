namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM27
{
static int SumRecursive(int num, int total=1)
{
    if (num == 1)
    {
        return total;
    }
    else
    {
        Console.WriteLine("재귀 호출 전달 받은 값 : {0}", num);
        return SumRecursive(num-1,num + total);
    }
}
static void Main_(string[] args)
{
    Console.WriteLine("더하기 꼬리 재귀 함수를 시작합니다 : 정수를 입력해주세요");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("재귀 호출 더하기 결과 : {0}", SumRecursive(n));
}
}