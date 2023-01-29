string[] array1 = { "123", "глаз", "3", "лом", "пятница", "65", "2222"};
string[] array2 = { "groot", "gen", "привет мир!", "geekbrains", "643.,.,.<!", "!!!"};
string[] array3 = { "17356345", "блог", ":-)", "gasdfgadf"};

void SortArray(string[] array) {
    string[] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                int arraySize = result.Length;
                Array.Resize(ref result, arraySize + 1);
                result[arraySize] = array[i];
            }
    }
    Console.WriteLine("Изначальный массив: [" + string.Join(", ", array) + "]");
    Console.WriteLine("Полученный массив: [" + string.Join(", ", result) + "]");
}


SortArray(array1);
SortArray(array2);
SortArray(array3);