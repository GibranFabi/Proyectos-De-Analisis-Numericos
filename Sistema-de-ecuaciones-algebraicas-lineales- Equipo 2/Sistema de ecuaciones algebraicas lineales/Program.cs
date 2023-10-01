class Program
{
    static void Main()
    {
        // Definimos el sistema de ecuaciones como una matriz y un vector
        // Ax = b, donde A es la matriz de coeficientes y b es el vector de términos constantes
        double[,] A = {{2, 1},
                       {1, 3}};
        double[] b = { 4, 7 };

        // Resolvemos el sistema de ecuaciones
        double[] x = SolveLinearSystem(A, b);

        // Imprimimos la solución
        Console.WriteLine("La solución del sistema de ecuaciones es:");
        Console.WriteLine($"x = [{x[0]}, {x[1]}]");
    }

    // Se define una función llamada "SolveLinearSystem" que toma como argumentos una matriz "A" y un vector "b".
    static double[] SolveLinearSystem(double[,] A, double[] b)
    {
        //Se realiza una verificación para asegurarse de que la matriz "A" sea cuadrada (misma cantidad de filas y columnas) y que el tamaño del vector "b" coincida con el número de filas de "A". Si estas condiciones no se cumplen, se lanza una excepción con un mensaje de error.
        if (A.GetLength(0) != A.GetLength(1) || A.GetLength(0) != b.Length)
        {
            throw new ArgumentException("La matriz A debe ser cuadrada y el tamaño del vector b debe coincidir con el número de filas de A.");
        }

        //Se obtiene el tamaño de la matriz "A" (número de filas) y se crea un nuevo arreglo "x" de tipo double con la misma longitud para almacenar las soluciones.
        int n = A.GetLength(0);
        double[] x = new double[n];

        // Resolvemos el sistema utilizando eliminación gaussiana
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                double factor = A[j, i] / A[i, i];
                b[j] -= factor * b[i];
                for (int k = i; k < n; k++)
                {
                    A[j, k] -= factor * A[i, k];
                }
            }
        }

        // Sustituimos hacia atrás para encontrar la solución
        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0.0;
            for (int j = i + 1; j < n; j++)
            {
                sum += A[i, j] * x[j];
            }
            x[i] = (b[i] - sum) / A[i, i];
        }

        return x;
    }
}