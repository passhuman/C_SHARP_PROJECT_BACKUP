namespace C_SHARP_PROJECT;
public class DAY4_PROGRAM9
{
    static void Main_(String []args){
        END_PROGRAM SW = new END_PROGRAM();
        SW.init();
        SW.start();
    }
}
public class Start_Program
{
    public virtual void init(){
        Console.WriteLine("프로그램의 최상위 1등 클래스입니다");
    }
    public void start(){
        Console.WriteLine("프로그램을 시작합니다");
    }
}
public class END_PROGRAM : Start_Program
{
    public override void init(){
        Console.WriteLine("프로그램의 최상위 2등 클래스입니다");
    }
    public new void start(){
        Console.WriteLine("프로그램을 시작합니다2");
    }
    
}