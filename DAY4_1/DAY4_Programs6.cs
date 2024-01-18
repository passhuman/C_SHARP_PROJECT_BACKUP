using System.ComponentModel;
using Hello_world;
using Hello_world1;

namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM6
{
    DAY3_PROGRAM6(){
        Console.WriteLine("DAY3_PROGRAMS : 객체 생성시 1회 수행.");
    }
static void Main6(String []args)
    {
        Console.WriteLine("생성자 호출 확인");
        Initial test = new Initial();
    }
}
class Initial{
    private readonly int number;
    private const int number2 = 5;
    public Initial(){
        number = 33;
        Console.WriteLine("initial : 객체 생성시 1회 수행");
    }
}