package JavaSyntax;

import java.util.Scanner;

/**
 * Created by krustev on 18-Mar-16.
 */
public class CharachterM {
    public static void main(String[] args) {

        Scanner input=new Scanner(System.in);

        String[] word=input.nextLine().split(" ");
        int result=multiplyStrings(word[0],word[1]);

        System.out.println(result);
    }

    public static int multiplyStrings(String str1, String str2) {
        int maxLenght=0;

        if(str1.length()>str2.length()){

            maxLenght=str1.length();
        }
        else{
            maxLenght=str2.length();
        }
        int result=0;
        for (int i = 0; i < maxLenght ; i++) {
            int value1=0;
            int value2=1;
            if(i>=str1.length()){
                value1=1;

            }
            else{
                value1=str1.charAt(i);
            }
            if(i>=str2.length()){
                value2=1;

            }
            else{
                value2=str2.charAt(i);
            }

           result+=value1*value2;
        }
        return result;
    }


}

