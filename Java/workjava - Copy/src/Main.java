import java.text.ParseException;

public class Main {
    public static void main(String[] args) throws ParseException {

        MyDate MyDate1 = new MyDate();
            String string  = MyDate1.toString();
            System.out.println("=======================================================");
            System.out.println(" Today: " + string);
            MyDate1.nextDay();
            string = MyDate1.toString();
            System.out.println(" Tommorrow: " + string);
            MyDate1.nextDay();
            string = MyDate1.toString();
            System.out.println(" Next Day: " + string);
            MyDate1.skipAhead(32);
            string = MyDate1.toString();
            System.out.println(" 32 Days Later: " + string);
            System.out.println("Testing Leap Year");
            System.out.println("========================");
            boolean myvalue;
            myvalue = MyDate1.isLeapYear(1900);
            System.out.println("Is 1900 a leap year: " + myvalue);
            myvalue = MyDate1.isLeapYear(2000);
            System.out.println("is 2000 a leap year: " + myvalue);

        System.out.println("Testing Birthday");
        System.out.println("========================");
        myvalue = MyDate1.isMyBirthday(8,13);
        System.out.println("is August 13, my Birthday?: " + myvalue);
        System.out.println("Testing equals");
        System.out.println("========================");
       myvalue = MyDate1.equals(07/13/1996);
        System.out.println(" is 07/13/1996 equal to the current date?: " + myvalue);
        MyDate MyDate2 = new MyDate(1,1,2000);
        boolean myotherval = MyDate2.equals(1/1/2000);
       System.out.println("Does 1/1/2000 equal the current date?: " + myvalue);

        System.out.println("Testing Printing Formats");
        System.out.println("========================");
        string = MyDate2.toString(1);
        System.out.println(string);
        string = MyDate2.toString(2);
        System.out.println(string);
        string = MyDate2.toString(3);
        System.out.println(string);
        string = MyDate2.toString(4);
        System.out.println(string);
        System.out.println("=======================================================");

    }
}
