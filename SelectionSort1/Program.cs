// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[size];
        
        Console.WriteLine($"Enter {size} numbers:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        SelectionSort selectionSort = new SelectionSort();
        selectionSort.selection(arr);

        Console.WriteLine("Array elements are:");
        foreach (int value in arr)
        {
            Console.WriteLine(value);
        }
