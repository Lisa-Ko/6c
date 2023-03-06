int[,] CreateInttable()
{
    Console.Write("Введите длину  ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите ширину  ");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,] table = new int[m,n];
    return  table;
}
void Filltable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = (i+1) + (j+1);
        }
    }
}
void Printtable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i,j]);
        }
     Console.WriteLine();
     }
}

int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);