string[] NewArray(string[] arr)
{
    int old_length = arr.Length;
    int new_length = 0;
    int index = 0;
    int[] index_arr = new int[old_length];
    for(int i = 0; i < old_length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            index_arr[index] = i;
            index++;
            new_length++;
        }
        
    }
    string[] new_arr = new string[new_length];
    for (int i = 0; i < new_length; i++)
    {
        new_arr[i] = arr[index_arr[i]];
    }
    return new_arr;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
    Console.WriteLine();
}
string[] arr = {"asdc", "4", "", "dasd", "hel"};
Console.WriteLine("Old array is:");
PrintArray(arr);
Console.WriteLine("New array is:");
PrintArray(NewArray(arr));