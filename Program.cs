  string[] array1 = new string[6] {"3", "700", "Kazan", "Uhta", "computer",":"};
  string[] array2 = new string[array1.Length];
 
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
 
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
 