string[] arrayStart = new string[8] {"dog", "hello", "config", "784569", "may", "stop", "mem", "456"};
string[] arrayFinal = new string[arrayStart.Length];

void GetArrayLengthFrom1to3Elements(string[] arrayStart, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if(arrayStart[i].Length <= 3)
        {
            arrayFinal[count] = arrayStart[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

GetArrayLengthFrom1to3Elements(arrayStart, arrayFinal);
PrintArray(arrayFinal);