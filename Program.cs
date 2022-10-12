Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols);
PrintArray(array);
Console.WriteLine();
SumArrayRows(array);


int[,] GetArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i,j] = new Random().Next(1, 26);
        }
    }
    return newArray;
}

void PrintArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumArrayRows(int[,] array) {
    int[] tempArr = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++) {        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sum += array[i, j];
        }
        for (int m = 0; m < tempArr.Length; m++) {
            tempArr[i] = sum;
        }
    }
    Console.WriteLine($"Sum in rows: [{String.Join(", ", tempArr)}]. ");
    int result = tempArr[0];
    int position = 0;
    for (int n = 0; n < tempArr.Length; n++) {        
        if (tempArr[n] < result) {
            result = tempArr[n];
            position = n;
        }
    }
    Console.WriteLine($"Minimal sum in row #{position} of your array: [{result}]");
}