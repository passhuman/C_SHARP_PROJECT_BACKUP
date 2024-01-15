namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM3
{
static string admin_Name = "관리자";
static void Main_(String []args)
    {
        Console.WriteLine("접근 지정자를 구분합세다.");
        string stName = "아저씨";
        admin_get std = new admin_get();
        std.oldMember1(stName);
    }
}
class admin_get{
    public void oldMember1(string name){
        Console.WriteLine("{0} 선생 1. 반갑습네다!", name);
    }
    static void oldMember2(string name){
        Console.WriteLine("{0} 선생2. 반갑습네다!", name);
    }
}