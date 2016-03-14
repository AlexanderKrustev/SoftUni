package JavaFundamentals;

import java.util.Scanner;

public class SumFrom1ToN {
    public static void main(String[] args) {

        Scanner in=new Scanner(System.in);
        String input=in.nextLine();
        int n=Integer.parseInt(input);
        int sum=0;

        for (int i = 1; i <=n ; i++) {
            sum+=i;
        }

        System.out.println(sum);
    }
}
