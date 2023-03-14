import java.text.ParseException;

import java.util.List;
import java.util.*;

public class main {
    public static void main(String[] args) throws ParseException {
        Scanner scnr = new Scanner(System.in);

        String myString = scnr.nextLine();
        String name = "";

        int myInt;
        while (!myString.equals("-1")) {
            try {
                String[] strings = myString.split(" ");

                if (strings.length > 1) {
                    name = strings[0];
                    myInt = Integer.parseInt(strings[1]);

                    System.out.println(name + " " + (myInt + 1));
                }


            } catch (NumberFormatException e) {
                System.out.println(name + " 0");
            }

            myString = scnr.nextLine();
        }
        // the program outputs that list with the age incremented
        //the program fails and throws an exception if the 2nd
        //input on a line is a String instead of an int.

    }
}

