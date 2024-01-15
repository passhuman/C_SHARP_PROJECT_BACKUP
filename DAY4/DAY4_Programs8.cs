namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM8
{
    ~DAY3_PROGRAM8(){
        Console.WriteLine("DAY3_PROGRAM7 : 소멸자 호출");
    }
static void Main8(String []args)
    {
        Console.WriteLine("생성자/소멸자 호출 확인");
        for (int i=0; i < 5; i++){
        initial3 test1 = new initial3(i);
        }
        GC.Collect();
    }
}
class initial3{
    public initial3(int a){
        int state = a;
        Console.WriteLine("initial : 인자값 {0}", state);
    }
    ~initial3(){
        Console.WriteLine("initial : 소멸자 호출");  
    }
}