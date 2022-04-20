Console.Write("Введите число: ");
int sqare = Convert.ToInt16(Console.ReadLine());

void FillArray(int[] collection){

  int lenght = collection.Length;
  int index = 0;
  
  while (index < lenght){
    collection[index] = new Random().Next(1, 10);
    index++;
  } 
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
}

int IndexOf(int[] collection, int find){
  int count = collection.Length;
  int index = 0;
  int position = -1;
  while (index < count){
    if (collection[index] == find) {
      position = index;
    }
    index++;
  }
  return position;
}

int[] arry = new int[sqare];

FillArray(arry);
PrintArry(arry);

Console.WriteLine();

int pos = IndexOf(arry, 4);
Console.WriteLine(pos);

