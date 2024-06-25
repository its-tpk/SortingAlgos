class RadixSort{
    public void radix(int[] arr){
        int max = arr.Max();
        int placeval = 1;
        while(max/placeval > 0)
        {
            countSort(arr,placeval);
            placeval *=10;
        }
    }

    public void countSort(int[] arr, int placeval){
        int num_digits = 10;

        int[] counts = new int[num_digits];
        foreach(int i in arr){
            int num = i/placeval;
            counts[num % num_digits]+=1;
        }
        
        int start = 0;
        for(int i=0;i<counts.Length;i++){
            int count = counts[i];
            counts[i]=start;
            start+=count;
        }

        int[] sortedarray = new int[arr.Length];
        foreach(int i in arr)
        {
            int num = i/placeval;
            sortedarray[counts[num % num_digits]] = i;

            counts[num % num_digits]+=1;
        }

        Array.Copy(sortedarray,arr,arr.Length);
    }
}