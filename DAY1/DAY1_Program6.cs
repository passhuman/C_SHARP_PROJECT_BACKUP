namespace Hello_world;

public class DAY1_Program6
{
    public static void PrintValue(dynamic val1)
    {
        Console.WriteLine(val1.GetType());
    }
static void Main_(string[] args){
    dynamic st_end, st_end2;
    st_end = 100; st_end2 = null;
    Console.WriteLine("데이터 값 : {0}, 데이터 타입 :" + st_end.GetType(), st_end); 
    st_end = 1.1;
    Console.WriteLine("데이터값: {0}, 데이터 타입: " + st_end.GetType(), st_end);
    st_end = "hello";
    Console.WriteLine("데이터 값 : {0}, 데이터 타입 : " + st_end.GetType(), st_end);
    
    PrintValue("HelloWorld");
    PrintValue(1000);
    PrintValue(10.50);
}
}