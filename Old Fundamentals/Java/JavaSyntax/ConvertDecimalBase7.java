package JavaSyntax;
import java.util.Scanner;

public class ConvertDecimalBase7 {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);

        int decimalNumber=in.nextInt();
        String result="";
        String result2="";

        while(decimalNumber%7!=0){

            result=result+(decimalNumber%7);
            decimalNumber=decimalNumber/7;
        }
        if(decimalNumber%7==0){
            result2="1";
        }

        char[] array=result.toCharArray();

        for (int i = array.length-1; i >= 0  ; i--) {
            result2 += array[i];
        }

        System.out.println(result2);
    }
}
