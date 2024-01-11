using System.Reflection.Metadata.Ecma335;

namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM14
{
static void Main_(String []args)
    {
        String message1 = "문자열 초기화";
        string message2 = message1 + " " + "afadddDDD";
        string code_message = @"
        public string ReadLine(string filename);
        {
            if (!string.IsNullOrEmpty(filename))
            {
                return File.ReadAllText(filename);
        }
        return string.Empty;
        }
        ";
    Console.WriteLine($"문자열\t 값 출력 1 : {message1}");
    Console.WriteLine($@"문자열\t 값 출력\n 2 : {message1}\t");
    Console.WriteLine($"문자열 값 출력 3 : {code_message}");
    Console.WriteLine($"문자열 길이 : {code_message.Length} 대소문자 {message2.ToLower()}");
    }

}
