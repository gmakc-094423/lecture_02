// Console.Write("Введите Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 || y == 0){
//   Console.WriteLine("X Y не должны быть равны 0");
//   return;
// }
// int quartersNumber = 1;

// if (x > 0 && y < 0){
// quartersNumber = 2;
// }
// if (x < 0 && y < 0){
// quartersNumber = 3;
// }
// if (x > 0 && y < 0){
// quartersNumber = 4;
// }

// Console.WriteLine($"Находится в {quartersNumber} четверти");
// Console.WriteLine($"Находится в {Int64.MaxValue} четверти");


// Console.Write("Введите номер четверти: ");
// int qarter = Convert.ToInt32(Console.ReadLine());

// if (qarter <= 0 || qarter >4) {
//   Console.WriteLine("не должнo быть равны 0");
//   return;
// }

// int x1 = 0;
// int x2 = 0;
// int y1 = 0;
// int y2 = 0;

// if (qarter == 1){
//   int x1 = 0;
//   int x2 = Int64.MaxValue;
//   int y1 = 0;
//   int y2 = Int64.MaxValue;
// }
// if (qarter == 2){
//     int x1 = 0;
//   int x2 = Int64.MaxValue;
//   int y1 = 0;
//   int y2 = Int64.MaxValue;
// }

// Console.WriteLine($"Х Находится в диапазоне от 0 до  {Int64.MaxValue}  ");



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве


// Console.Write("Введите Х первой точки: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y первой точки: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите Х второй точки: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y второй точки: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

/* 
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
}
// double decision = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
Console.WriteLine($"Длина отрезка  {Convert.ToInt64(Decision(x1, x2, y1, y2))}  "); */



Console.Write("Введите число: ");
int sqare = Convert.ToInt32(Console.ReadLine());

int Sqare(int sqare){
  int counter = 1;

  int[] xxx = new int[sqare];
  while (counter <=  sqare){
    // Console.Write($"{Math.Pow(counter, 2)} ");
    double counter1 = Convert.ToDouble(counter);
    xxx[(counter-1)] = Math.Pow(counter1, 2);
    counter++;
  }
  return xxx;
}

int x = Sqare(sqare);

Console.Write($"{x} ");