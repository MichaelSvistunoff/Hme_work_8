Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols);
PrintArray(array);
Console.WriteLine();
SortArrayRows(array);
PrintArray(array);


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

void SortArrayRows(int[,] array) {
    int min = 0;
    int tmp = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1)-1; j++) {
            min = j;
            for (int m = j + 1; m < array.GetLength(1); m++) {
                if (array[i, m] > array[i, min]) {
                    min = m;
                }
            }
            if (min!=i) {
                tmp = array[i, j];
                array[i, j] = array[i, min];
                array[i, min] = tmp;
            }
        }
    }
}