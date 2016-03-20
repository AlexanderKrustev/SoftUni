package JavaSyntax;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
/**
 * Created by krustev on 18-Mar-16.
 */
public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);
        String[] input=in.nextLine().split(" ");
        List<Integer> numbers=new ArrayList<>();
        List<Integer> result= new ArrayList<>();
        for (String str:input) {
            numbers.add(Integer.parseInt(str));
        }
        String forPrint="";
        String[] commands=in.nextLine().split(" ");
        switch(commands[2]){
            case "even": {
                result=firstEvenNumbers(Integer.parseInt(commands[1]),numbers);
            }break;
            case "odd": {
                result=firstOddNumbers(Integer.parseInt(commands[1]),numbers);
            }break;
        }

        for (int n:result) {
            System.out.print(n+" ");
        }

    }

    public static List<Integer> firstOddNumbers(int n, List<Integer> array){
        List<Integer> result= new ArrayList<>();
        int count=0;
        for (int i = 0; i < array.size() ; i++) {
            if(array.get(i)%2!=0){
                result.add(array.get(i));
                count++;
            }
            if(count==n){
                break;
            }
        }

        return result;
    }
    public static List<Integer> firstEvenNumbers(int n, List<Integer> array){
        List<Integer> result= new ArrayList<>();
        int count=0;
        for (int i = 0; i < array.size() ; i++) {
            if(array.get(i)%2==0){
                result.add(array.get(i));
                count++;
            }
            if(count==n){
                break;
            }
        }

        return result;
    }

}
