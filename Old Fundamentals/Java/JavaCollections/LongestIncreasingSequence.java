import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * Created by krustev on 27-Mar-16.
 */
public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner in= new Scanner(System.in);
        String[] inputString= in.nextLine().split(" ");
        List<List<Integer>> subsequences=new ArrayList<>();
        ArrayList<Integer> numbers=new ArrayList<>();
        for (String s : inputString) {
            numbers.add(Integer.parseInt(s));

        }
        subsequences.add(new ArrayList<>());
        int countOfSubs=0;
        subsequences.get(countOfSubs).add(numbers.get(0));
        for (int i = 1; i <numbers.size() ; i++) {
            if(numbers.get(i-1)<numbers.get(i)){
                subsequences.get(countOfSubs).add(numbers.get(i));
            }
            else{
                subsequences.add(new ArrayList<>());
                subsequences.get(++countOfSubs).add(numbers.get(i));
            }
        }
         int maxSize=0;
         int maxSizePosstion=0;
        for (int i = 0; i <subsequences.size() ; i++) {

            for (int subsequence : subsequences.get(i)) {
                System.out.printf("%d ",subsequence);
            }
            System.out.println();
            if(maxSize<subsequences.get(i).size()){
                maxSize=subsequences.get(i).size();
                maxSizePosstion=i;
            }
        }
        System.out.print("Longets: ");
        for (int integer : subsequences.get(maxSizePosstion)) {
            System.out.printf("%d ",integer);
        }

    }
}
