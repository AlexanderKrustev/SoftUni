import java.util.Scanner;

/**
 * Created by krustev on 28-Mar-16.
 */
public class RecursiveBinarySearch {
    public static void main(String[] args) {
     Scanner in=new Scanner(System.in);
        String numberStr=in.nextLine();
        int number=Integer.parseInt(numberStr);
        String[] arrSrt=in.nextLine().split(" ");
        int[] arr=new int[arrSrt.length];
        for (int i = 0; i < arrSrt.length; i++) {
            arr[i]=Integer.parseInt(arrSrt[i]);

        }
        System.out.println(binarySearch(arr, number));
    }
    public static int binarySearch(int[] a, int target) {
        return binarySearch(a, 0, a.length-1, target);
    }

    public static int binarySearch(int[] a, int start, int end, int target) {
        int middle = (start + end) / 2;
        if(end < start) {
            return -1;
        }

        if(target==a[middle]) {
            return middle;
        } else if(target<a[middle]) {
            return binarySearch(a, start, middle - 1, target);
        } else {
            return binarySearch(a, middle + 1, end, target);
        }
    }

}
