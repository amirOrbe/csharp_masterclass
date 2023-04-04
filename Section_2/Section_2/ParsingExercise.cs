public class Section2ParsingExercise
{
    public static void Main(string[] args)
    {
        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int

        float floatForString = float.Parse(stringForFloat);
        int intForString = int.Parse(stringForInt);
        Console.WriteLine(floatForString);
        Console.WriteLine(intForString);
        Console.Read();
    }
}
