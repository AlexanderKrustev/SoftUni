import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by krustev on 28-Mar-16.
 */
public class FilterArray {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);

        String[] words=in.nextLine().split(" ");
        List<String> filteredStr=Arrays.stream(words).filter(FilterArray::isLenghtMoreThan3).collect(Collectors.toList());
        if(filteredStr.isEmpty()){
            System.out.println("(empty)");
        }
        else{
            for (String s: filteredStr) {
                System.out.print(s+" ");
            }
        }
    }
    public static boolean isLenghtMoreThan3(String s){
        if(s.length()>3){
            return true;
        }
        else{
            return false;
        }
    }
}
