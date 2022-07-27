void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}.");
        }
    Console.WriteLine();
}

int CountStringLessThreeChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) count++;
        }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
                {
                    result[result.Length - count] = array[i];
                    count--;
                }
        }
    return result;
}

string[] arrayOfStrings =  {"hello", "2", "world", ":-)"};
int countArray = CountStringLessThreeChar(arrayOfStrings);
string[] resultArray =  FillResultArray(arrayOfStrings, countArray);

PrintArray(resultArray);
