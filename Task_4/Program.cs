// Вывести ряд до определенного числа, например, задано 12 вывести: 1 2 2 3 3 3 4 4 4 4 5 5

int ReadInt(string msg)// объявляем функцию msg строковую
{
    Console.WriteLine(msg);//пишет на экран параметр msg
    string a = Console.ReadLine();
    int numb;
    numb = int.Parse(a);//преобразуем строку в число
    return numb;// возврат из функции
}
 void FindRowNumbers(int number)
{
  for (int i = 1; i <= number; i++)
    {
        for (int count = 1; count <= i; count++)
        {
        Console.Write(i +" ");
        }
    }  
}

int max = ReadInt("Введите число: ");
FindRowNumbers(max);
