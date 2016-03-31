import java.util.Scanner;

/**
 * Created by krustev on 28-Mar-16.
 */
public class CalculateFactoriel {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);
        String str=in.nextLine();
        int number=Integer.parseInt(str);
        System.out.println(calculateFactorial(number));
    }

    public static int calculateFactorial(int n){
        if (n <= 1) {
           return 1;
        }
            return calculateFactorial(n - 1) * n;


    }
}
