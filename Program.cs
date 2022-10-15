Console.Write("Enter number of rows of array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns of array: ");
int cols = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] arrayOne = GetArray(rows, cols);
PrintArray(arrayOne);
Console.WriteLine();
int[,] arrayTwo = GetArray(cols, rows);
PrintArray(arrayTwo);
Console.WriteLine();
int[,] result = MultiplicationArrays(arrayOne, arrayTwo);
PrintArray(result);



int[,] GetArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i,j] = new Random().Next(1, 26);
        }
    }
    return newArray;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationArrays(int[,] arrayOne, int[,] arrayTwo) {
    int[,] resultArray = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayOne.GetLength(0); i++) {
        for (int j = 0; j < arrayTwo.GetLength(1); j++) {
            for (int moveIndex = 0; moveIndex < arrayTwo.GetLength(0); moveIndex++) {
                resultArray[i, j] += arrayOne[i, moveIndex] * arrayTwo[moveIndex, j];
            }
        }
    }
    return resultArray;
}