namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM9
{
    static string admin_Name = "학생";
    static void Main9(String []args)
    {
        Console.WriteLine("학생 호출 확인");
        string stName = Console.ReadLine();
        initial2 test1 = new initial2();
        initial2 test2 = new initial2(4);
        initial2 test3 = new initial2(100, "홍길동");
    }
}    
