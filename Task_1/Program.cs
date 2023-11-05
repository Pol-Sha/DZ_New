// Найти 2й максимум в массиве, 2й максимум, это число, больше которого только максимум

int ReadInt(string msg)// объявляем функцию msg строковую
{
    Console.WriteLine(msg);//пишет на экран параметр msg
    string a = Console.ReadLine();
    int numb;
    numb = int.Parse(a);//преобразуем строку в число
    return numb;// возврат из функции
}
int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);

    }
    return array;
}
void printArray(int[] array)
{
    System.Console.Write(array[0]);             // Вывод 1-го элемента массива
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");  // Вывод текущего элемента массива
    }
    System.Console.WriteLine();                 // Перевод строки (чтобы отделять массивы)
}
int FindSecondMaximumElement(int[] array)
{
    int FirstMax = 0;
    int SecondMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = array[i];
        if (temp > FirstMax)
        {
            SecondMax = FirstMax;
            FirstMax = temp;
        }
        else if (temp > SecondMax && temp < FirstMax)
        {
            SecondMax = temp;
        }
    }


    return SecondMax;
}


int length = ReadInt("Введите длину массива: ");
int minVal = ReadInt("Введите минимальное число массива: ");
int maxVal = ReadInt("Введите максимиальное число массива: ");
int[] numbers = GenerateArray(length, minVal, maxVal);
printArray(numbers);
int secmaximum = FindSecondMaximumElement(numbers);
Console.WriteLine($"Второе макисмальное число в массиве: {secmaximum}");

