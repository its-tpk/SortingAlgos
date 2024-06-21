
class BubbleSort{
    public void bubble(int[] arr){
        bool isswapped = true;
        while(isswapped){
            isswapped =false;
            for(int i=0;i<arr.Length-1;i++){
                if(arr[i]>arr[i+1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1]=temp;
                    isswapped=true;
                }
            }
        }
    }
}