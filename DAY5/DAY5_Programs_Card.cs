using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace C_SHARP_PROJECT;
public class DAY5_PROGRAM_CARD
{
    static int Add(int rand, int rand2)
    {   
        return rand - rand2;
    }
    static void stage1()
    {
        for(int loop = 3 - 1; loop >= 0; loop--)
        {
        Console.WriteLine($"카드뽑기 {1}.({3}번까지 수행), {2}. 메뉴로 돌아가기");
        int cat = int.Parse(Console.ReadLine());

        Random rand = new Random();
        Random rand2 = new();

        Console.WriteLine("0번째 사용자 카드 뽑기 결과: " + rand.Next(0, 100));
        Console.WriteLine("0번째 컴퓨터 카드 뽑기 결과: " + rand2.Next(0, 100));

        Console.WriteLine("카드게임의 결과: {0}", Add);
        }
    }
    static void stage2()
    {
    Random rand = new Random();
    for(int loop = 0; loop < 100; loop++)
        {
            Console.WriteLine("0 ~ 100 사이의 랜덤 값: " + rand.Next(0, 100));
        }
    }
    static void Main_(string []args)
    {   

        Console.WriteLine("카드 게임을 시작합니다: {1}. 게임시작, {2}. 카드 자동 뽑기, {3}.게임종료", stage1, stage2, args);
        int meow = int.Parse(Console.ReadLine());

    }

}