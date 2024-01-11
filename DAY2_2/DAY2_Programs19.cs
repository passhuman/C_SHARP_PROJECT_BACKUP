namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM19
{
static void Main_(string[] args)
    {
    int argsCount = args.Length;
    
    if (argsCount < 2)
    {
        Console.WriteLine("사용법 : MyApp.exe {inputFilename} {outputFilename}");
        Console.WriteLine("MyApp.exe data.inp data.out");
        return;
    }
    string inputFile = args[0];
    string outputFile = args[1];

    Console.WriteLine("입력 파일: {0}, 출력 파일: {1}", inputFile, outputFile);
    }
}