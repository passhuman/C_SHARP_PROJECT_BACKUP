namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM2
{
static string admin_Name = "관리자";
static void Main_(string []args)
    {
        Console.WriteLine("클래스 변수와 인스천스 변수 구별이 되나요?");
        Console.WriteLine("선생 이름을 입력해주세요: ");
        string stName = Console.ReadLine();

        admin_new std = new admin_new();
        admin_new.oldMember(stName);
        admin_new.temp = "임시에 접근";
        std.newMember(stName);
    }
}
class admin_new{
    public static string temp = "임시";
    public void newMember(string name){
        Console.WriteLine("{0} 학생. 반갑습네다!", name);
    }
    public static void oldMember(string name){
        Console.WriteLine("{0} 선생. 반갑습네다!", name);
    }
}