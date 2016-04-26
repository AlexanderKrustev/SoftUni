package JavaFundamentals;
import java.util.Scanner;
/**
 * Created by krustev on 14-Mar-16.
 */
public class GetAvarage {
    public static void main(String[] args) {
        Scanner in=new Scanner(System.in);

        double a=Double.parseDouble(in.nextLine());
        double b=Double.parseDouble(in.nextLine());
        double c=Double.parseDouble(in.nextLine());

        System.out.printf("%.2f",(a+b+c)/3.0);
    }
}
