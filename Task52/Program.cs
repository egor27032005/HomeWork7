Console.Clear();
double[,] CreateArrayDouble(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd =new Random();
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
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
double Сalculations(double [,] matrix)
{
    double resalt =0;
    for (int j =0; j<matrix.GetLength(1); j++)
    {
        double sum =0;
        for (int i =0; i<matrix.GetLength(0); i++)
        {
            sum+= matrix[i, j];
        }
        resalt=sum/matrix.GetLength(0);
        Console.WriteLine(resalt);
    }
    return resalt;
} 
Double[,] array2D=CreateArrayDouble(5, 5, -9, 9);
PrintMatrix(array2D); 
Сalculations(array2D); 