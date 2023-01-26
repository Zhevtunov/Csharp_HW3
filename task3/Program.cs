// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int GetNum(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

void Cubes(int num)
{
  int i = 1;
  while (i < num)
  {
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
  }
  Console.Write(Math.Pow(i, 3));
}

int number = GetNum("Введите число: ");

Cubes(number);