class InsertionSort{
    public void insertion(int[] arr){
        
        for(int i=1;i<arr.Length;i++){
            int curr_index = i;
            while(curr_index>0 && arr[curr_index-1]>arr[curr_index]){
                int temp = arr[curr_index];
                arr[curr_index]=arr[curr_index-1];
                arr[curr_index-1]= temp;
                curr_index-=1;
            }
        }
    }

  public void insertionSort(int[] arr) {
        // Mutates elements in arr by inserting out of place elements into appropriate
        // index repeatedly until arr is sorted
        for (int i = 1; i < arr.Length; i++) {
            int currentIndex = i;
            while (currentIndex > 0 && arr[currentIndex - 1] > arr[currentIndex]) {
                // Swap elements that are out of order
                int temp = arr[currentIndex];
                arr[currentIndex] = arr[currentIndex - 1];
                arr[currentIndex - 1] = temp;
                currentIndex -= 1;
            }
        }
    }
}