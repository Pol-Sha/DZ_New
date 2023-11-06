// Подсчитать количество заданных чисел в массиве


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
int FindCountElement(int[] array)
{
Console.WriteLine("Введите искомое число: ");
string line = Console.ReadLine();
int element = int.Parse(line);
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (element == array[i])
        {
        count ++;
        }   
    }    
return count;
}

int length = ReadInt("Введите длину массива: ");
int minVal = ReadInt("Введите минимальное число массива: ");
int maxVal = ReadInt("Введите максимиальное число массива: ");
int[] numbers = GenerateArray(length, minVal, maxVal);
printArray(numbers);
int countElem = FindCountElement(numbers);
if (countElem !=0)
{
    Console.WriteLine($"количество элементов равно {countElem}");
}
else 
{
    Console.WriteLine("Таких элементов не найдено!");
}