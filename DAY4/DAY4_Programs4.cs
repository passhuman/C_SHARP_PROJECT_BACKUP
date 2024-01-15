namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM4
{
static void Main_(String []args)
    {
        Console.WriteLine("private 데이터 접근 어떻게 하나?.");
        string stName = "아저씨";
        admin_get2 std = new admin_get2();
        Console.WriteLine("기밀 정보, 주민 정보 몰래 출력 {0}, {1}", std.get_info1(), std.get_info2());
        std.set(516555);
        std.set(stName);
        Console.WriteLine("기밀정보, 주민정보 수정 후 출력 {0}. {1}", std.get_info1(), std.get_info2());
    }
}
class admin_get2{
    private string info1 = "기밀정보";
    private int info2 = 901112;

    public string get_info1(){
        return info1;
    }
    public int get_info2(){
        return info2;
    }
    public void set(string set_info1){
        info1 = set_info1;
    }
    public void set(int set_info2){ // public 으로 지정
        info2 = set_info2;
    }
}
