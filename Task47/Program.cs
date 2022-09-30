Console.Clear();
double[,] CreateArrayDouble(int rows, int colums, double min, double max)
{
    double[,] matrix = new double[rows, colums];
    Random fixRand =new Random();
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
Console.Write("Введите число m ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n =Convert.ToInt32(Console.ReadLine());
Double[,] array2D=CreateArrayDouble(m, n, -9, 9);
PrintMatrix(array2D);   