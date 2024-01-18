public class DAY4_PROGRAM8
{
    static void Main_(String []args){
        Human SW = new Human();
    }
    sealed class Human
{
    public void init(){
        Console.WriteLine("밥을 먹는다");
        Console.WriteLine("걷는다");
    }
    int name = 0;
    int age = 0;
    int cm = 0;

}
    public class Teacher
{
    public void Start(){
        Console.WriteLine("공부를 한다");
        Console.WriteLine("아이들을 가르친다");
    }
    int study = 0;
}
    public class Students
{
    public void Start(){
        Console.WriteLine("공부를 한다");
        Console.WriteLine("학원을 간다");
    }
    int class_name = 0;
}
    public class Workers
{
    public void Start(){
        Console.WriteLine("일을 한다");
        Console.WriteLine("출근을 한다");
    }
    int Work_name = 0;
}
}