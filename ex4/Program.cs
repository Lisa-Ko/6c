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
            table[i,j] =new Random().Next(0, 10);
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
void Change(int[,] table)
{    
   
    for (int j = 0; j < table.GetLength(1); j++)
    {
        int count = table[0,j];
        table[0,j] = table[table.GetLength(0)-1,j];
        table[table.GetLength(0)-1,j] = count;
    }
    Console.WriteLine("измененный массив: ");
    Printtable(table);
}

int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);
Change(numbers);