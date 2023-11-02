//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.

Console.Write("Введите количество элементов в массиве от 1 до 10: ");

int countElements = Convert.ToInt32(Console.ReadLine());

bool validateInputCountElement = ValidateInputCountElement(countElements);
if (! validateInputCountElement) {
    Console.WriteLine("Кол-во элементов должно быть от 1 до 10");
    return;
}

bool ValidateInputCountElement(int validateValue)
{
    if (validateValue > 10 || validateValue < 1)
    {
        return false;
    }

    return true;   
}
