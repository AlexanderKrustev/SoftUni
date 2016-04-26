package JavaFundamentals;
import java.util.Scanner;
/**
 * Created by krustev on 14-Mar-16.
 */
public class GhettoNumeralSystem {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);
        String input=in.nextLine();
        String[] all=input.split("");
        StringBuilder sb=new StringBuilder();
        for (String eachChar:all) {

        switch (eachChar) {
            case "0":
                sb.append("Gee");
                break;
            case "1":
                sb.append("Bro");
                break;
            case "2":
                sb.append("Zuz");
                break;
            case "3":
                sb.append("Ma");
                break;
            case "4":
                sb.append("Duh");
                break;
            case "5":
                sb.append("Yo");
                break;
            case "6":
                sb.append("Dis");
                break;
            case "7":
                sb.append("Hood");
                break;
            case "8":
                sb.append("Jam");
                break;
            case "9":
                sb.append("Mack");
                break;
        }
        }
        String result=sb.toString();
        System.out.println(result);
    }
}
