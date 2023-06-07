string IfNumberIsNegative(int[] array)
{
    string result = string.Empty;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count++;
        else continue;
    }
    return result + count;
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return result;
}




try
{
    Console.Write("Insert the quantity of numbers that your array should contain = ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 1)
    {
        int[] mainarray = new int[num];
        for (int i = 0; i < num; i++)
        {
            Console.Write("Insert the number = ");
            mainarray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        Console.Write("Your array: ");
        PrintArray(mainarray);
        Console.WriteLine();
        Console.Write("The quantity of negative numbers in the array = ");
        Console.WriteLine(IfNumberIsNegative(mainarray));
    }
    else if (num == 0 || num == 1) Console.WriteLine("You may not insert this number - try another one");
    else Console.WriteLine("You may insert only positive numbers");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}