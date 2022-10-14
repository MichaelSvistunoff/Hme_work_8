int[,] arrayOne = new int[4, 4];

GetArray(arrayOne);
PrintArray(arrayOne);

void GetArray(int[,] arrInput) {
    int count = 1;
    int size = arrInput.GetLength(0) * arrInput.GetLength(1);
    int i = 0;
    int j = 0;

    while (count <= size) {        
        arrInput[i,j] = count++;  
        if (i <= j + 1 && i + j < arrInput.GetLength(1) - 1) {
            j++;
        } else if (i < j && i + j >= arrInput.GetLength(0) - 1) {
            i++;
        } else if (i >= j && i + j > arrInput.GetLength(1) - 1) {
            j--;
        } else {
            i--;
        }  
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (array[i,j]<10) {
                Console.Write($"0{array[i,j]} ");
            } else {                
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}