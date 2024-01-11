namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM25
{
    static void Main_(string[] args){
        int readonlyArgument = 44;
        InArgExample(readonlyArgument);

        void InArgExample(in int number)
        {
            Console.WriteLine("in 인자값 출력 {0}: ", readonlyArgument);
            //number = 19;
        }
    }
}