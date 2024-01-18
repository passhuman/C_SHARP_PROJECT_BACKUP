namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM6{
    static void Main_(String []args){
        SUB_PROGRAM2 sw = new SUB_PROGRAM2();
        sw.Start();
    }
}
public class Main_Program2{
    protected int protected_check1 = 15;
    protected static int protected_check2 = 15;
    protected void init(){
        Console.WriteLine("프로그램의 치상위 클래스입니다");
    }
}
public class SUB_PROGRAM2 : Main_Program2{
    DAY4_PROGRAM6 test = new DAY4_PROGRAM6();
    int temp = protected_check2 = 55;
    public void Start(){
        int temp = base.protected_check1 + 1;
        init();
        Console.WriteLine("프로그램을 시작합네다");
    }
}