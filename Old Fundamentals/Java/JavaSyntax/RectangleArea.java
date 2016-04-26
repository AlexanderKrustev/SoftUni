package JavaSyntax;
import java.util.Scanner;
/**
 * Created by krustev on 16-Mar-16.
 */
public class RectangleArea {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);
        String[] input=in.nextLine().split(" ");
        int a=Integer.parseInt(input[0]);
        int b=Integer.parseInt(input[1]);
        System.out.println(a*b);
    }
}
