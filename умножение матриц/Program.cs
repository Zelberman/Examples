Console.WriteLine("Задача №58");

Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");

Console.WriteLine("Введите количество строк первой квадратной матрицы");
int a00 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов первой квадратной матрицы");
int a01 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк второй квадратной матрицы");
int b00 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов второй квадратной матрицы");
int b01 = int.Parse(Console.ReadLine()!);

if (a01 == b00)
{

    int[,] GetmatrixA(int aa00, int aa01)
    {

        int[,] matrixA = new int[aa00, aa01];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            Console.WriteLine($"Заполните значениями строку № {i} первого массива");
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                matrixA[i, j] = int.Parse(Console.ReadLine()!);
                // Console.WriteLine($"\t{matrixA[i,j]}"); 
            }
        }
        return matrixA;
    }

    int[,] GetmatrixB(int bb00, int bb01)
    {

        int[,] matrixB = new int[bb00, bb01];

        for (int i = 0; i < matrixB.GetLength(0); i++)
        {
            Console.WriteLine($"Заполните значениями строку № {i} второго массива");
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixB[i, j] = int.Parse(Console.ReadLine()!);
            }
        }
        return matrixB;
    }

    int[,] GetMatrixAB(int Ma00, int Mb01, int Ma01, int[,] matrixAA, int[,] matrixBB)
    {

        int[,] matrixAB = new int[Ma00, Mb01];

        for (int i = 0; i < matrixAB.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAB.GetLength(1); j++)
            {
                int n = Ma01;
                if (n == 1)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j];
                }
                if (n == 2)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j];
                }
                if (n == 3)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j];
                }
                if (n == 4)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j];
                }
                if (n == 5)
                { 
                     matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j];
                }
                if (n == 6)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j]+ matrixAA[i, 5] * matrixBB[5, j];
                }
                if (n == 7)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j]+ matrixAA[i, 5] * matrixBB[5, j]+ matrixAA[i, 6] * matrixBB[6, j];
                }
                if (n == 8)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j]+ matrixAA[i, 5] * matrixBB[5, j]+ matrixAA[i, 6] * matrixBB[6, j]+ matrixAA[i, 7] * matrixBB[7, j];
                }
                if (n == 9)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j]+ matrixAA[i, 5] * matrixBB[5, j]+ matrixAA[i, 6] * matrixBB[6, j]+ matrixAA[i, 7] * matrixBB[7, j]+ matrixAA[i, 8] * matrixBB[8, j];
                }
                if (n == 10)
                {
                    matrixAB[i, j] = matrixAA[i, 0] * matrixBB[0, j] + matrixAA[i, 1] * matrixBB[1, j] + matrixAA[i, 2] * matrixBB[2, j] + matrixAA[i, 3] * matrixBB[3, j] + matrixAA[i, 4] * matrixBB[4, j]+ matrixAA[i, 5] * matrixBB[5, j]+ matrixAA[i, 6] * matrixBB[6, j]+ matrixAA[i, 7] * matrixBB[7, j]+ matrixAA[i, 8] * matrixBB[8, j]+ matrixAA[i, 9] * matrixBB[9, j];
                }

            Console.WriteLine();
        }
        }
        return matrixAB;
    }

    void Print(int[,] printMatrix)
    {
        for (int i = 0; i < printMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < printMatrix.GetLength(1); j++)
            {
                Console.Write($"\t{printMatrix[i, j]}");
            }
            Console.WriteLine();
        }
    }


    int[,] MatrixA = GetmatrixA(a00, a01);
    int[,] MatrixB = GetmatrixB(b00, b01);
    Console.WriteLine("Произведение двух матриц равно:");
    int[,] MatrixAxB = GetMatrixAB(a00, b01, a01, MatrixA, MatrixB);

    Console.WriteLine("Матрица A");
    Print(MatrixA);
    Console.WriteLine("Матрица B");
    Print(MatrixB);
    Console.WriteLine("Матрица А * B");
    Print(MatrixAxB);

    Console.WriteLine();


}
else
{
    Console.WriteLine("количество столбцов первой матрицы не равно количеству строк второй матрицы");
}