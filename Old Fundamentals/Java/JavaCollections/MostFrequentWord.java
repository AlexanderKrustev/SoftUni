import java.lang.reflect.Array;
import java.util.*;

/**
 * Created by krustev on 27-Mar-16.
 */
public class MostFrequentWord {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);

        String input=in.nextLine();
        String[] words=input.split("[^\\w']+");
        HashMap<String,Integer> wordCounter=new HashMap<>();
        for (String word : words) {
            if(!word.equals("") && !wordCounter.containsKey(word.toLowerCase())){
                wordCounter.put(word.toLowerCase(),1);
            }
            else{
                wordCounter.put(word.toLowerCase(), wordCounter.get(word.toLowerCase())+1);
            }
        }
        int max=0;
        for(Map.Entry<String, Integer> kvp:wordCounter.entrySet()){
            if(kvp.getValue()>max){
                max=kvp.getValue();
            }
        }
        ArrayList<String> list=new ArrayList<>();
        list.addAll(wordCounter.keySet());
        Collections.sort(list);
        for (int i = 0; i <list.size() ; i++) {
            if(wordCounter.get(list.get(i))==max){
                System.out.printf("%s -> %d times",list.get(i),wordCounter.get(list.get(i)));
                System.out.println();
            }

        }
    }
}
