package JavaSyntax;
import java.util.Scanner;
/**
/**
 * Created by krustev on 16-Mar-16.
 */
public class TriangleArea {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);
        String[] input=in.nextLine().split(" ");
        int aX=Integer.parseInt(input[0]);
        int aY=Integer.parseInt(input[1]);
        String[] input2=in.nextLine().split(" ");
        int bX=Integer.parseInt(input2[0]);
        int bY=Integer.parseInt(input2[1]);
        String[] input3=in.nextLine().split(" ");
        int cX=Integer.parseInt(input3[0]);
        int cY=Integer.parseInt(input3[1]);
       // System.out.println(""+aX+""+aY);
        int area=Math.abs(aX*(bY-cY)+bX*(cY-aY)+cX*(aY-bY))/2;
        System.out.printf("%d",area);
    }
}


