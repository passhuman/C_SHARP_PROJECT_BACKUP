namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM15
{
static void Main_(String []args)
    {
        string message1 = "오늘은 정말 '배고픈' 날입니다! HELLO";
        int message_index = message1.IndexOf("HE");
        Console.WriteLine($"문자열 위치(인덱스) : {message_index}");
        Console.WriteLine($"문자열 자르기1 : {message1.Substring(message_index, 5)}");
        Console.WriteLine($"특정 문자 변경 : {message1.Replace('L', 'I')}");

        string[] message2 = message1.Split('\'',' ');
        foreach(var word in message2){
        Console.WriteLine($"문자열 자르기2 : {word}");
        }
        
        string message3 = "HELLO WORLD!";
        string reversed = new string(message3.Reverse().ToArray());
        Console.WriteLine($"문자열 뒤집기 : {reversed}");
    }
}