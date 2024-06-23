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
}