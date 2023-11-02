//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.

Console.Write("Введите количество элементов в массиве от 1 до 10: ");

int countElements = Convert.ToInt32(Console.ReadLine());

bool validateInputCountElement = ValidateInputCountElement(countElements);
if (! validateInputCountElement) {
    Console.WriteLine("Кол-во элементов должно быть от 1 до 10");
    return;
}

string[] primaryArray = new string[countElements];
FillPrimaryArray(primaryArray);

int countSecondaryArrayElements = CountSecondaryArrayElements(primaryArray);
string[] secondaryArray = new string[countSecondaryArrayElements];
FillSecondaryArray(primaryArray, secondaryArray);

PrintArray(primaryArray);
Console.Write(" -> ");
PrintArray(secondaryArray);
Console.WriteLine();

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void FillSecondaryArray(string[] filledPrimaryArray, string[] emptySecondaryArray)
{
    int j = 0;
    for (int i = 0; i < filledPrimaryArray.Length; i++) {
        if (filledPrimaryArray[i].Length <= 3) {
            emptySecondaryArray[j] = filledPrimaryArray[i];
            j++;
        }
    }
}

int CountSecondaryArrayElements(string[] filledArray)
{
    int countSecondaryArrayElements = 0;
    for (int i = 0; i < filledArray.Length; i++) {
        if (filledArray[i].Length <= 3) {
            countSecondaryArrayElements++;
        }
    }
    return countSecondaryArrayElements;
}

void FillPrimaryArray(string[] fillableArray)
{
    for (int i = 0; i < fillableArray.Length; i++) {
        Console.Write($"Введите {i + 1} элемент: ");
        fillableArray[i] = Console.ReadLine();
    }
}

bool ValidateInputCountElement(int validateValue)
{
    if (validateValue > 10 || validateValue < 1)
    {
        return false;
    }

    return true;   
}
