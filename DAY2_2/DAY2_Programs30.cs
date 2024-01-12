namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM30
{
    static void Main_(string[] args)
    {
        int cnt = 3;
        int avg = 0;
        Console.WriteLine("학생의 이름과 점수를 입력합니다");

        int[] numbers = new int[cnt];

        for(int i=0; i < cnt; i++){
        Console.WriteLine("{0}번째 학생의 이름을 입력해 주세요 :", i);
        string? input = Console.ReadLine();
        }
        for(int i=0; i < cnt; i++){
        Console.WriteLine("{0}번째 학생의 점수는?", i);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
            
        Console.WriteLine("학생의 점수 평균 값 : {0}", numbers.Average());
    }
    
}