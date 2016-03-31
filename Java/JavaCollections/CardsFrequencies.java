import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by krustev on 27-Mar-16.
 */
public class CardsFrequencies {
    public static void main(String[] args) {

        Scanner in= new Scanner(System.in);
        String[] input=in.nextLine().split(" ");
        HashMap<String, Integer> records=new HashMap<>();
        for(String str:input){
            String[] agrs=str.split("");
            String card=agrs[0];
            if(card.equals("1")){
                card+="0";
            }
            if(records.containsKey(card)){
                records.put(card, records.get(card)+1);
            }
            else{
                records.put(card, 1);
            }
        }
        for (Map.Entry<String,Integer> kvp : records.entrySet()) {
            double percetnage=(kvp.getValue()/(double)input.length)*100;
            String output=String.format("%s -> %.2f",kvp.getKey(),percetnage);
            System.out.println(output);
        }
    }
}
