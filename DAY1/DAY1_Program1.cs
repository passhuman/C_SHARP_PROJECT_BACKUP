namespace Hello_world1;
class DAY1_Program1
{
    public DAY1_Program1(){
    String man = "아저씨1";
    Console.WriteLine("Hello, World1!");
    Console.WriteLine(man);
    }
}
//둘로 분리되었어
class DAY1_Program1_
{
    static void Main_(String[] args){
        String man ="아저씨2";
        Console.WriteLine("Hello, World2!");
        Console.WriteLine(man);
        var test = new DAY1_Program1();
    }
}