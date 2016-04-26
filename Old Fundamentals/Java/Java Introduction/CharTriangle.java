package JavaFundamentals;
import org.omg.PortableInterceptor.SYSTEM_EXCEPTION;

import java.util.Scanner;

public class CharTriangle {

    public static void main(String[] args) {

        Scanner input=new Scanner(System.in);
        String str=input.nextLine();
        int n=Integer.parseInt(str);
        int count=0;
        char ch='a';
        for (int i = 1; i <= n; i++) {
            for (int j=0; j<i; j++) {
                System.out.print((ch++) +" ");

            }
            ch='a';
            System.out.println();
        }

        for (int i = n-1; i >= 1; i--) {
            for (int j=i; j>0; j--) {
                System.out.print((ch++) +" ");

            }
            ch='a';
            System.out.println();
        }
    }
}
