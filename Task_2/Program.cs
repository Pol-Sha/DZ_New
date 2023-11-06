// Найти медиану в массиве. Медианой называется число, 
// стоящее в упорядоченном ряде чисел посередине. 
// Например в ряду: 1, 2, 3, 7, 9 — тройка является медианой. 
// Если количество чисел чётное, то за медиану принимают среднее двух стоящих в центре чисел.

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
int FindMediana(int[] array) // нахождение медианы в массиве
{
    int SizeArray = array.Length % 2;
    int mediana = 0;
    if (SizeArray == 1) // если число элементов в массиве нечетное
    {
        
            mediana = array[array.Length / 2];
      
    }        
    else  // если число элементов в массиве чётное
    {
        mediana  = array[array.Length / 2 - 1] + array[array.Length / 2];
    }
return mediana;
}





int length = ReadInt("Введите длину массива: ");
int minVal = ReadInt("Введите минимальное число массива: ");
int maxVal = ReadInt("Введите максимиальное число массива: ");
int[] numbers = GenerateArray(length, minVal, maxVal);
printArray(numbers);
int element = FindMediana(numbers);
Console.WriteLine($"Значение медианы массива равно {element}");