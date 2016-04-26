import com.sun.deploy.util.StringUtils;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by krustev on 25-Mar-16.
 */
public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {

        Scanner input=new Scanner(System.in);

        String[] words=input.nextLine().split(" ");
        Map<String,Integer> wordOccurrence=new HashMap<>();
        int maxCount=0;
        String result="";
        for (String str: words) {
            if(wordOccurrence.containsKey(str)) {
                wordOccurrence.put(str, wordOccurrence.get(str) + 1);
            }
            else{
                wordOccurrence.put(str,1);
            }
        }
        for (Map.Entry<String, Integer> kvp: wordOccurrence.entrySet()) {

           if(kvp.getValue()>maxCount){
               maxCount=kvp.getValue();
               result=kvp.getKey();
           }
        }
        result=result+" ";

        for (int i = 0; i <maxCount ; i++) {

            System.out.print(result+" ");
        }

        System.out.println();
    }
}
