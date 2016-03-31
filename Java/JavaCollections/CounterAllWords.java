import java.util.*;

/**
 * Created by krustev on 27-Mar-16.
 */
public class CounterAllWords {
    public static void main(String[] args) {
        Scanner in= new Scanner(System.in);

        String input=in.nextLine();
        String[] words=input.split("[^\\w']+");


        List<String> wordCounter=new ArrayList<>();
        for (String word : words) {
            if(!word.equals("")){
                wordCounter.add(word);
            }
        }
        System.out.println(wordCounter.size());
    }
}
