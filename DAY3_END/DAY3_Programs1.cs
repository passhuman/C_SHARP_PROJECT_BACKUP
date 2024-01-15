namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM_END
{
    static void Main_(string []args)
    {
        program_start();
    }

    static void program_start()
    {   
        Console.WriteLine("주민 등록 번호 13자리를 입력해주세요");
        string number = Console.ReadLine();
        string number1 = number.Substring(0, 6);
        number1 += "********";
        Console.WriteLine(number1);

        bool valid = number_check(number);
        Console.Write("주민등록번호가 {0}", valid?"유효합니다.":"유효하지 않습니다.");
        string _gen = number.Replace(" ","").Replace("-","")[6].ToString();
        if(valid) Console.WriteLine("{0}", int.IsOddInteger(int.Parse(_gen)) ? " 남자" : " 여자");
        else Console.WriteLine();
    }


    static bool number_check(string RRN)

{

    //공백 제거

    RRN = RRN.Replace(" ", "");

    //문자 '-' 제거

    RRN = RRN.Replace("-", "");

    //주민등록번호가 13자리인가?

    if (RRN.Length != 13)

    {

        return false;

    }

 

    int sum = 0;

    for (int i = 0; i < RRN.Length - 1; i++)

    {

        char c = RRN[i];

        //숫자로 이루어져 있는가?

        if (!char.IsNumber(c))

        {

            return false;

        }

        else

        {

            if (i < RRN.Length)

            {

                //지정된 숫자로 각 자리를 나눈 후 더한다.

                sum += int.Parse(c.ToString()) * ((i % 8) + 2);

            }

        }

    }

    // 검증코드와 결과 값이 같은가?

    if (!((((11 - (sum % 11)) % 10).ToString()) == ((RRN[RRN.Length - 1]).ToString())))

    {

        return false;

    }

    return true;

}
}

