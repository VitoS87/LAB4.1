try
{
    Random r = new Random();
    int[] mas1 = new int[8];
    for (int i = 0; i < mas1.Length; i++)
    {
        mas1[i] = r.Next(10,99);
        Console.Write($"{mas1[i]} ");
    }
    Console.WriteLine();
    int[] mas2 = new int[8];
    mas1.CopyTo(mas2, 0);
    for (int i = 0; i < mas1.Length; i++)
    {
        mas2[i] %= 10;
        Console.Write($"{mas2[i]} ");
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}