
class HeapSort{
    public void heap(int[] arr){
        for(int i=arr.Length/2 -1 ; i>=0;i--){
            maxHeapify(arr, arr.Length,i);
        }

        for(int i=arr.Length-1;i>0;i--){
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i]=temp;

            maxHeapify(arr,i,0);
        }
    }

    public void maxHeapify(int[] arr, int heapSize, int index){
            int left = index*2 +1;
            int right = index*2 +2;
            int largest = index;
            if(left<heapSize && arr[left]>arr[largest])
            largest = left;
            if(right<heapSize && arr[right]>arr[largest])
            largest = right;

            if(largest!=index){
                 int temp = arr[largest];
            arr[largest] = arr[index];
            arr[index]=temp; 
            maxHeapify(arr,heapSize,largest);
            }
    }
}