package JavaSyntax;
import java.util.*;

/**
 * Created by krustev on 18-Mar-16.
 */
public class RandomNumbersNtoM {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);

        int n=in.nextInt();
        int m=in.nextInt();
        int down=0;
        int up=0;
        if(m>n){
            up=m;
            down=n;
        }
        else{
            up=n;
            down=m;
        }
        List<Integer>  omg= new ArrayList<>();
        for (int i = down; i <=up ; i++) {
            omg.add(i);
        }
        Collections.shuffle(omg);
        System.out.println(omg);
    }
}
