import java.util.*;

/**
 * Created by krustev on 27-Mar-16.
 */
public class CombineListsOfLetters {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);
        String[] input1=in.nextLine().split(" ");
        String[] input2=in.nextLine().split(" ");

        List<String> set1=new ArrayList<>();
        List<String> set=new ArrayList<>();
        for (int i = 0; i < input1.length; i++) {
           set1.add(input1[i]);
            set.add(input1[i]);

        }
        for (int i = 0; i < input2.length; i++) {
            if(!set1.contains(input2[i])){
                set.add(input2[i]);
            }

        }
        for (String s:set) {
            System.out.print(s+" ");
        }
        System.out.println();

    }
}
