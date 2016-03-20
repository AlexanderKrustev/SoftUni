package JavaSyntax;
import java.util.Map;
import java.util.Scanner;
/**
 * Created by krustev on 16-Mar-16.
 */
public class CalculateExpression {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);

        double a=in.nextDouble();
        double b=in.nextDouble();
        double c=in.nextDouble();

        double f1=Math.pow((a*a+b*b)/(a*a-b*b),(a+b+c)/Math.sqrt(c));
        double f2=Math.pow((Math.pow(a,2)+ Math.pow(b,2)-Math.pow(c,3)),(a-b));
        double f3=Math.abs(((a+b+c)/3) -((f1+f2)/2));
        System.out.format("F1 result: %1.2f; F2 result: %2.2f; Diff: %3.2f",f1,f2,f3);
    }
}
