import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by krustev on 27-Mar-16.
 */
public class CountSpecificWord {
    public static void main(String[] args) {
        Scanner in= new Scanner(System.in);

        String input=in.nextLine();
        String[] words=input.split("[^\\w']+");
        String pattern=in.nextLine();
        int counter=0;
        for (String word : words) {
            if(word.equalsIgnoreCase(pattern)){
              counter++;
            }
        }
        System.out.println(counter);
    }
}
