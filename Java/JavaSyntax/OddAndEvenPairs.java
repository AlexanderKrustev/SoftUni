package JavaSyntax;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by krustev on 18-Mar-16.
 */
public class OddAndEvenPairs {
    public static void main(String[] args) {

        Scanner in =new Scanner(System.in);

        String[] input=in.nextLine().split(" ");
        List<Integer> numbers=new ArrayList<>();
        if(input.length%2!=0){
            System.out.println("Invalid lenght");
        }
        else{
            for (String s:input) {
                numbers.add(Integer.parseInt(s));
            }
            for (int i = 0; i < numbers.size() ; i=i+2) {
                if(numbers.get(i) %2==0 && numbers.get(i+1)%2==0){
                    System.out.printf("%1d, %2d -> both are even\n", numbers.get(i), numbers.get(i+1));

                }
                else if(numbers.get(i) %2!=0 && numbers.get(i+1)%2!=0){
                    System.out.printf("%1d, %2d -> both are odd\n", numbers.get(i), numbers.get(i+1));

                }
                else{
                    System.out.printf("%1d, %2d -> different\n", numbers.get(i), numbers.get(i+1));

                }
            }
        }
    }
}
