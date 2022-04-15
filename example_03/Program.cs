int[] arry = {12,25,33,24,52,46,4,18,79,10};

int n = arry.Length;

int find = 4;

int index = 0;

while (index < n) {

  if(arry[index] == find ) {
    Console.WriteLine(index);
    break;
  }

  index += 1;
}