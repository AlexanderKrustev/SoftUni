package JavaSyntax;

import java.util.Scanner;

/**
 * Created by krustev on 18-Mar-16.
 */
public class HitTheTarget {
    public static void main(String[] args) {

        Scanner input=new Scanner(System.in);
        int target = input.nextInt();
        int[] numbers=new int[20];
        for (int i = 1; i <=20 ; i++) {
            numbers[i-1]=i;
        }

        for (int i = 1; i <=20 ; i++) {

            for (int j = 1; j <= 20 ; j++) {
                if(i+j == target){
                    System.out.printf("%1d + %2d = %3d\n",i,j,target);
                }
            }
        }
        for (int i = 1; i <= 20 ; i++) {

            for (int j = 1; j <= 20 ; j++) {
                if(i-j == target){
                    System.out.printf("%1d - %2d = %3d\n",i,j,target);
                }
            }
        }
    }
}
