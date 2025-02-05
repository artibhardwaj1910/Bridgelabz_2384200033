using System;
namespace Assignment05Level3
{
    class MatrixOperations  {
        // Method to create a random matrix given the number of rows and columns
        public static double[,] CreateRandomMatrix(int rows, int columns)
        {
            Random rand = new Random();
            double[,] matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(1, 10); // Random values between 1 and 9
                }
            }

            return matrix;
        }

        // Method to add two matrices
        public static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        // Method to subtract two matrices
        public static double[,] SubtractMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        // Method to multiply two matrices
        public static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);

            if (columns1 != rows2)
                throw new InvalidOperationException("Matrix dimensions do not match for multiplication.");

            double[,] result = new double[rows1, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < columns1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        // Method to find the transpose of a matrix
        public static double[,] TransposeMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            double[,] result = new double[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

        // Method to find the determinant of a 2x2 matrix
        public static double Determinant2x2(double[,] matrix)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                throw new InvalidOperationException("Matrix must be 2x2 to find determinant.");

            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        // Method to find the determinant of a 3x3 matrix
        public static double Determinant3x3(double[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
                throw new InvalidOperationException("Matrix must be 3x3 to find determinant.");

            double determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                               - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                               + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return determinant;
        }

        // Method to find the inverse of a 2x2 matrix
        public static double[,] Inverse2x2(double[,] matrix)
        {
            double determinant = Determinant2x2(matrix);

            if (determinant == 0)
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");

            double[,] inverse = new double[2, 2];
            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }

        // Method to find the inverse of a 3x3 matrix
        public static double[,] Inverse3x3(double[,] matrix)
        {
            double determinant = Determinant3x3(matrix);

            if (determinant == 0)
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");

            double[,] inverse = new double[3, 3];

            inverse[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinant;
            inverse[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / determinant;
            inverse[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinant;

            inverse[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / determinant;
            inverse[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinant;
            inverse[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / determinant;

            inverse[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinant;
            inverse[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / determinant;
            inverse[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinant;

            return inverse;
        }

        // Method to display a matrix
        public static void DisplayMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Main method to execute matrix operations
        static void Main(string[] args)
        {
            // Create two random matrices
            double[,] matrix1 = CreateRandomMatrix(3, 3);
            double[,] matrix2 = CreateRandomMatrix(3, 3);

            Console.WriteLine("Matrix 1:");
            DisplayMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            DisplayMatrix(matrix2);

            // Add matrices
            double[,] sumMatrix = AddMatrices(matrix1, matrix2);
            Console.WriteLine("Matrix 1 + Matrix 2:");
            DisplayMatrix(sumMatrix);

            // Subtract matrices
            double[,] diffMatrix = SubtractMatrices(matrix1, matrix2);
            Console.WriteLine("Matrix 1 - Matrix 2:");
            DisplayMatrix(diffMatrix);

            // Multiply matrices
            double[,] productMatrix = MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("Matrix 1 * Matrix 2:");
            DisplayMatrix(productMatrix);

            // Transpose matrix1
            double[,] transposeMatrix = TransposeMatrix(matrix1);
            Console.WriteLine("Transpose of Matrix 1:");
            DisplayMatrix(transposeMatrix);

            // Determinant of 2x2 matrix
            double[,] matrix2x2 = CreateRandomMatrix(2, 2);
            Console.WriteLine("2x2 Matrix:");
            DisplayMatrix(matrix2x2);
            Console.WriteLine("Determinant of Matrix 2x2: " + Determinant2x2(matrix2x2));

            // Determinant of 3x3 matrix
            Console.WriteLine("Determinant of Matrix 3x3: " + Determinant3x3(matrix1));

            // Inverse of 2x2 matrix
            double[,] inverse2x2 = Inverse2x2(matrix2x2);
            Console.WriteLine("Inverse of 2x2 Matrix:");
            DisplayMatrix(inverse2x2);

            // Inverse of 3x3 matrix
            double[,] inverse3x3 = Inverse3x3(matrix1);
            Console.WriteLine("Inverse of 3x3 Matrix:");
            DisplayMatrix(inverse3x3);
        }
    }
}



