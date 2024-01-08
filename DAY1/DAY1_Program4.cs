namespace Hello_world;
public class DAY1_Program4
{
static void Main_(string[] args){
    int x, y, z;
    String X, Y, Z;
    x = y = z = 50;
    X = Y = Z = "HELLO_WORLD1 ";

    Console.WriteLine(x + y + z);
    Console.WriteLine(x + y + z);
    Console.WriteLine(x + "아저씨{0}", z);
    Console.WriteLine(x + "아저씨{0}{1}", z, y);
    Console.WriteLine(x + "아저씨{1}{0}{1}", z, y);
    Console.WriteLine("오늘 홍길동은" + "{0}를" +$"{x}번 외칩니다.", x);
}
}