Console.Clear();
int[,] CreateArrayDouble(int rows, int colums, int min, int max, int ia, int ja)
{
    int [,] matrix = new int[rows, colums];
    Random rnd =new Random();
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
        }
    }
    if (ia<rows && ja<colums && ja>=0 && ia>=0)
    Console.WriteLine("искомое число " +matrix[ia, ja]);
    else
    Console.WriteLine("Такого числа нет");

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        Console.Write("["); 
        for(int j =0; j<matrix.GetLength(0); j++)
        {
            if( j <matrix.GetLength(1)-1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");    
    }
}
Console.Write("Введите число строк ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов ");
int n =Convert.ToInt32(Console.ReadLine());
int[,] array2D=CreateArrayDouble(5, 5, -9, 9, m, n);
PrintMatrix(array2D); 