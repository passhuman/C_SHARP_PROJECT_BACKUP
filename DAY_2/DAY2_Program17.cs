namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM17
{
static void Main_(String []args)
    {
        int message1 = 0;
        int message2 = 0;
        Console.WriteLine("문자열 2개를 입력해 주세요 :");
        string[] input = Console.ReadLine().Split(' ');
        message1 = int.Parse(input[0]);
        message2 = int.Parse(input[1]);
        Console.WriteLine($"문자열 비교 1 : {string.Equals(message1, message2)}");

        string message_max = "";
        Console.WriteLine($"문자열 길이 및 숫자 포함 검사 결과: {String.IsNullOrEmpty(message_max)}");
    }   
}