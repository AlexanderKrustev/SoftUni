package JavaSyntax;
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);
        int a=in.nextInt();

        double b=in.nextDouble();
        double c=in.nextDouble();
        String bin=String.format("%10S",Integer.toBinaryString(a)).replace(' ','0');
        System.out.printf("|%-10X|%s|%10.2f|%10.3f|",a,bin,b,c);

    }
}
