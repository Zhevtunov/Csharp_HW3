// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int GetNum(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

void Сoordinates(int ax, int ay, int az, int bx, int by, int bz)
{
  double rezult = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
  
  Console.WriteLine(rezult);
}

int ax = GetNum("Ведите координату х первого числа: ");
int ay = GetNum("Ведите координату y первого числа: ");
int az = GetNum("Ведите координату z первого числа: ");
int bx = GetNum("Ведите координату x второго числа: ");
int by = GetNum("Ведите координату y второго числа: ");
int bz = GetNum("Ведите координату z второго числа: ");

Сoordinates(ax, ay, az, bx, by, bz);