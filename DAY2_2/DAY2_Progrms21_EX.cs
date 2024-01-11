using System.ComponentModel;
using System.Net;

namespace C_SHARP_PROJECT;

public class DAY2_PROGRAM21_EX
{   
static void Program_start(string[] arg)
    {
    int cnt = 0;
    Console.WriteLine("사칙 연산에 필요한 수의 개수는? :");
    cnt = int.Parse(Console.ReadLine());

    int[] numbers = new int[cnt];

    for(int i=0; i < cnt; i++){
        Console.WriteLine("{0}번째 데이터를 입력 :", i);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("계산기 메뉴 : 1. 더하기 2. 곱하기 3. 종료 4");
    int meow = int.Parse(Console.ReadLine());
    }
static int Add(int x, int y)
{   
    
    return x + y;
}

static int Mul(int X, int Y)
{
    return X * Y;
}
static void Main_(string[] arg)
{
    Console.WriteLine("두 수를 합한 결과는 : {0}", Add);
    Console.WriteLine("두 수를 곱한 결과는 : {0}", Mul);
}

}
