// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your size of array");

int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
Console.WriteLine("Enter array elements");
for(int i=0;i<len;i++)
{
arr[i] = Convert.ToInt32(Console.ReadLine());
}

RadixSort radixSort = new RadixSort();

radixSort.radix(arr);

Console.WriteLine("Here is your sorted array");
for(int i=0;i<len;i++){
    Console.Write(arr[i]+" "); 
}



