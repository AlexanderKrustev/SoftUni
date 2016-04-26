package JavaSyntax;

import java.util.Scanner;

/**
 * Created by krustev on 18-Mar-16.
 */
public class ConvertBase7ToDecimal {
    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);

        int sevenBasedNumber=input.nextInt();
        double decimlBasedNumber=0;
        int power=0;
        while(sevenBasedNumber>0){
            decimlBasedNumber+=(sevenBasedNumber%10)*Math.pow(7,power);
            power++;
            sevenBasedNumber=sevenBasedNumber/10;
        }

        System.out.printf("%.0f",decimlBasedNumber);

    }
}
