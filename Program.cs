int[, ,] arrayOne = new int[2, 2, 2];
GetArray(arrayOne);
PrintArray(arrayOne);

void GetArray(int[, ,] arrInput) {
    int difNum = 0;
    int[] arrayToGetIndexes = new int[
                                    arrInput.GetLength(0) * 
                                    arrInput.GetLength(1) * 
                                    arrInput.GetLength(2)];
    int count = 0;
    
    for (int i = 0; i < arrayToGetIndexes.Length; i++) {
        arrayToGetIndexes[i] = new Random().Next(10, 100);
        difNum = arrayToGetIndexes[i];
        if (i >= 1) {
            for (int j = 0; j < i; j++) {
                if (arrayToGetIndexes[i] == arrayToGetIndexes[j]) {
                    arrayToGetIndexes[i] = new Random().Next(10, 100);
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
            for (int n = 0; n < arrInput.GetLength(2); n++) {             
                arrInput[i,j,n] = arrayToGetIndexes[count];
                count++;
            }
        }
    }
}

void PrintArray(int[, ,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int n = 0; n < array.GetLength(2); n++) {
                Console.Write($"{array[i,j,n]}({i},{j},{n}) ");
            }
        }
        Console.WriteLine();
    }
}