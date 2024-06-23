class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество слов");
        int count = Convert.ToInt32(Console.ReadLine());

        string[] arrayString = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите слово");
            arrayString[i] = Console.ReadLine();

        }

        string[] resultArray = FilterStringsByLength(arrayString, 3);

        Console.WriteLine($"[{string.Join(", ", arrayString)}] -> [{string.Join(", ", resultArray)}]");
    }

    static string[] FilterStringsByLength(string[] array, int maxLength)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            result[index] = str;
            index++;
        }
    }

    return result;
}