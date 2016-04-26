import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by krustev on 25-Mar-16.
 */
public class SortArrayNumbers {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        String rows=in.nextLine();
        int countOfNumbers=Integer.parseInt(rows);
        int[] array=new int[countOfNumbers];
        String input=in.nextLine();
        String[] stringNumbers=input.split(" ");
        int arrayIndex=0;
        for (String str:stringNumbers) {
            array[arrayIndex++]=Integer.parseInt(str);

        }
        Arrays.sort(array);
        for (int n:array) {
            System.out.print(n+" ");

        }
        System.out.println();
    }
}
