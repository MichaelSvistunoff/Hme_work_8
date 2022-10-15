int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
SortArrayRows(array);
PrintArray(array);


int[,] GetArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i,j] = new Random().Next(1, 10);
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
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int m = 0; m < array.GetLength(1)-1; m++) {
                if (array[i, m] < array[i, m+1]) {
                    int tmp = array[i, m+1];
                    array[i, m+1] = array[i, m];
                    array[i, m] = tmp;
                }
            }
        }
    }
}