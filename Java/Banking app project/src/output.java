// Final Project: Banking Application
// Project Week: ThanksGiving
//output page
//Java Class
// Gabriel Lackie



import java.util.ArrayList;
import java.util.Scanner;
public class output {
    private Scanner scnr;
    File file = new File();


    public output(){

    }

    public void Balance(int index){
        try {
            Record bat = file.Read(index);
            System.out.println(bat.Name + " Current Balance is $" + bat.currentSavings + " in savings" +
                    " and the balance is $" + bat.currentChecking + " in checking");
        }
        catch(Error error){
            System.out.println(" sorry but our System has expirienced an error, please try again later");
        }
    }
    public void Balance(){
        File file = new File();
        ArrayList <Record> batman = file.Read();
        Record bat;
        try {
            for (int i = 0; i < batman.size(); i++) {
                bat = batman.get(i);
                System.out.println(bat.Name + " Current Balance is $" + bat.currentSavings + " in savings" +
                        " and the balance is $" + bat.currentChecking + " in checking");
            }
        }
        catch (Error e ){System.out.println("sorry we could not print your balance");}

    }
}





