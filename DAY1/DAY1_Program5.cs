namespace Hello_world;
//var i = 20;
public class DAY1_Program5
{
    //var i = 20;
static void Main_(string[] args){
    var i = 20;
    var st = "행복합";
    var d = 20.333;
    var st_end ="니다";
    //var st_end;
    //var st_end = 123;
    st_end = "니까?";

    Console.WriteLine("{0}"+"{1}{2}"+st_end, i, st, d);
    Console.WriteLine("데이터 타입 확인 :", i.GetType());
    Console.WriteLine("데이터 타입 확인 :" + st.GetType());
    Console.WriteLine("데이터 타입 확인 :" + d.GetType());
}

}