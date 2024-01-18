using System.Runtime.CompilerServices;
using C_SHARP_PROJECT;

public class DAY4_PROGRAM7
{
    static void Main_(String []args){
        SUB_PROGRAM SW = new SUB_PROGRAM();
        SW.Start();
    }
}
sealed class Main_Program
{
    public void init(){
        Console.WriteLine("프로그램의 최상위 클래스입니다");
    }
}
public class SUB_PROGRAM
{
    public void Start(){
        Console.WriteLine("프로그램을 시작합니다");
    }
}