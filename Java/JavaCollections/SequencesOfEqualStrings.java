import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by krustev on 25-Mar-16.
 */
public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);

        String[] words=input.nextLine().split(" ");
        Map<String,Integer> wordOccurrence=new HashMap<>();
        for (String str: words) {
              if(wordOccurrence.containsKey(str)) {
                  wordOccurrence.put(str, wordOccurrence.get(str) + 1);
              }
            else{
                  wordOccurrence.put(str,1);
              }
        }
        for (Map.Entry<String, Integer> kvp: wordOccurrence.entrySet()) {

            for (int i = 0; i <kvp.getValue() ; i++) {
                System.out.print(kvp.getKey()+" ");
            }
            System.out.println();
        }

     }
}
