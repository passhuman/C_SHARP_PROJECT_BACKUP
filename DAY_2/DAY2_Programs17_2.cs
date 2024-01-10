namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM17_2
{
static void Main(String []args)
    {
        string[] name_array = ["아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리",];


        int message1 = 0;
        Console.WriteLine("이름을 입력해 주세요 :");
        string? input = Console.ReadLine();
        bool found = false;
        foreach(string s in name_array){
            found |= s == input;
            if(found) break;
            message1++;
        }

        if(found) Console.WriteLine($"{input}의 위치:{message1}");
        else Console.WriteLine("고양이");
    }
}