
class SelectionSort {


    public void selection(int[] arr){
        for(int i = 0; i<arr.Length;i++){
            int min_index = i;
            for(int j=i+1;j<arr.Length;j++)
            if(arr[j]<arr[min_index])
            min_index = j;

            int temp = arr[min_index];
            arr[min_index] = arr[i];
            arr[i] = temp;
        }
    }

  
}