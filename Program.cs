/*написать программу, которая из имеющегося массива строк формирует массив из 
строк длина которых меньше либо равна 3 символа. */

string[] text ={"hello", "2", "world", ";-)"};

PrintArray(text);

ArrayConversion(text);

PrintArray(text);

void ArrayConversion(string[] array)
{
    string element = String.Empty;
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        element = array[i];
        size = element.Length;
        if (size > 3)
        {
            array[i] = "";
        }

    }
    
}
void PrintArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}