namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM21
{
    static void Main_(string[] args)
    {
        int a = 3;
        int b = 6;
        int c = 7;
        paramsPratice(new int[] {a, b, c});
        int[] array = paramsPratice(a, b, c);

        Console.WriteLine("PARAMS 키워드 테스트 : 단순 배열 출력");
        foreach(var cnt in array){
            Console.WriteLine(cnt);
        } 
    }
    public static int[] paramsPratice(params int[] array)
    {
        return array;
    }
}