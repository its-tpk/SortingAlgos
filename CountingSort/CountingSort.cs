class CountingSort{
    public void count(int[] arr){
        int max = arr.Max();
        int[] counts= new int[max +1];
        foreach(int i in arr)
            counts[i]+=1;

            int start = 0;
            for(int i = 0;i<max+1;i++){
                int count = counts[i];
                counts[i] = start;
                start+=count;

            }

            int[] sortedarray = new int[arr.Length];
            foreach(int i in arr){
                sortedarray[counts[i]] = i;

                counts[i]+=1;
            }

            for(int i=0;i<arr.Length;i++){
                arr[i]=sortedarray[i];
            }
    }
}