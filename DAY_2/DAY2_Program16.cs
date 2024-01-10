namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM16
{
static void Main_(String []args)
    {
        string message1, message3;
        message1 = message3 = "오늘은 정말 배아파요!";
        string message2 = "오늘은 정말 배가 불러요?";
        string message4 = "HELLO_WORLD!";
        string message5 = "hello world!";
        Console.WriteLine($"문자열 비교 1 : {string.Equals(message1, message3)}");
        Console.WriteLine($"문자열 비교 2 : {message1 == message3}");
        Console.WriteLine($"문자열 비교 3 : {string.Compare(message1, message3)}");
        Console.WriteLine($"문자열 비교 4 : {string.Compare(message1, message2)}");
        Console.WriteLine($"문자열 비교 5 : {message4 == message5}");
        Console.WriteLine($"문자열 비교 6 : {message4.Equals(message5, StringComparison.OrdinalIgnoreCase)}");

        string message_null1 = "";
        string message_null2 = " ";
        string message_null3 = "\n";
        Console.WriteLine($"문자열 널 확인 1: {string.IsNullOrEmpty(message_null1)}");
        Console.WriteLine($"문자열 널 확인 2: {string.IsNullOrEmpty(message_null2)}");
        Console.WriteLine($"문자열 널 확인 3: {string.IsNullOrWhiteSpace(message_null2)}");
        Console.WriteLine($"문자열 널 확인 4: {string.IsNullOrEmpty(message_null3)}");
    }
}