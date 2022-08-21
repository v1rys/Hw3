void PerTurnover(int []arr)
{
      
    for(int i = arr.Length - 1;  i >=0; i--)
    {
        Console.WriteLine(arr[i]);
    }
}

int [] array= {1,2,3,4,5,6,7,8,9};
PerTurnover(array);

