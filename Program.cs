int[,] arrayOne = new int[4, 4];

GetArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
SortColsOfArray(arrayOne);
PrintArray(arrayOne);

void GetArray(int[,] arrInput) {
    int difNum = 0;
    int[] arrayToGetIndexes = new int[
                                    arrInput.GetLength(0) * 
                                    arrInput.GetLength(1)];
    int count = 0;
    
    for (int i = 0; i < arrayToGetIndexes.Length; i++) {
        arrayToGetIndexes[i] = new Random().Next(10, 100);
        difNum = arrayToGetIndexes[i];
        if (i >= 1) {
            for (int j = 0; j < i; j++) {
                if (arrayToGetIndexes[i] == arrayToGetIndexes[j]) {
                    arrayToGetIndexes[i] = new Random().Next(1, 26);
                    j = 0;
                    difNum = arrayToGetIndexes[i];
                } else {
                    difNum = arrayToGetIndexes[i];
                }
            }
        }
    }

    
    for (int i = 0; i < arrInput.GetLength(0); i++) {
        for (int j = 0; j < arrInput.GetLength(1); j++) {            
                arrInput[i,j] = arrayToGetIndexes[count];
                count++;
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

void SortColsOfArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) { 
            if (j%2==0) { 
                
            } else {                    
                for (int m = 0; m < array.GetLength(0)-1; m++) {
                    if (array[m, j] > array[m+1, j]) {
                        int tmp = array[m+1, j];
                        array[m+1, j] = array[m, j];
                        array[m, j] = tmp;
                    } 
                }
            }
        }
    }
}