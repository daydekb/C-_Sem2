int n = 100;
int[] arr = new int[n];
int i = 0;

while (1 < arr.Length)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
