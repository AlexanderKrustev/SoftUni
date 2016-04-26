import com.sun.scenario.effect.impl.sw.sse.SSEBlend_SRC_OUTPeer;
import com.sun.xml.internal.ws.util.StreamUtils;

import java.util.*;
import java.util.stream.*;
/**
 * Created by krustev on 31-Mar-16.
 */
public class SortArray {
    public static void main(String[] args) {


    Scanner in=new Scanner(System.in);

    String[] words=in.nextLine().split(" ");
        String command=in.nextLine();
        List<Integer> filteredStr=new ArrayList<>();
        filteredStr = Arrays.stream(words).map(Integer::parseInt).collect(Collectors.toList());
        if(command.equals("Ascending")) {
           filteredStr.stream().sorted().forEach(System.out::print);
        }
        if(command.equals("Descending")) {
            Comparator<Integer> comp = (a, b) -> a.compareTo(b);
            filteredStr.stream().sorted(comp.reversed())
                    .forEach(System.out::print);
        }


    }
}