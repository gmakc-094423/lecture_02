int number = RandomNumber(100, 999);

Console.WriteLine(number);

int newNumber = MaxNumber(number);

int RandomNumber(int min, int max){   
  return new Random().Next(min, max);
}


int MaxNumber(int number)
{
  int number2 = number / 100 * 10 + number % 10;

  int number1 = number / 100;
  int number3 = number % 10;
  
  Console.WriteLine("Строка  " + Convert.ToString(number1) + Convert.ToString(number3));
  
  return number2;
}

Console.WriteLine("Число " + newNumber);



int number = RandomInt(100, 1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine(stringNumber[0] + stringNumber[2]);

int RandomInt(int inclusiveMin, int exclusiveMax)
{
    return new Random().Next(inclusiveMin, exclusiveMax);
}
