// Final Project: Banking Application
// Project Week: ThanksGiving
//Main Page
//Java Class
// Gabriel Lackie

import java.lang.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scnr = new Scanner(System.in);
        var YesContinue = false;
        String Menu1;
        ArrayList<Record> records = new ArrayList<>();
        System.out.println("welcome to a banking application,");
        System.out.println(" if you want to add a client to the system press lowercase a");
        System.out.println(" if you want to print out your balance press b");
        System.out.println("if you want to make a deposit or withdraw to savings or checking press c");
        System.out.println(" if you want to view a clients information press lowercase d");
        Menu1 = scnr.next();
        do {
            if (Menu1.equals("a")) {
                System.out.println("you've chosen to create an account for a new client");
                input inputClass = new input(scnr);
                inputClass.addClient();
            } else if (Menu1.equals("b")) {
                System.out.println("you've chosen to check your balance");
               output outman = new output();
               System.out.println("enter the index of your account");
               int integer = scnr.nextInt();
               outman.Balance(integer);

            }


            else if (Menu1.equals("c")) {
                System.out.println("you've chosen to make a deposit or make a withdrawl");
                input input = new input(scnr);
                System.out.println("please enter index number of the account");
                int client = scnr.nextInt();
                input.clientAccountDeposit(client);

            } else if (Menu1.equals("d")) {
                System.out.println(" you've chosen to view  all client information");
                output outone = new output();
                    outone.Balance();
            } else if (Menu1.equals("e")) {
                    System.out.println("you've chosen to calculate your monthly interest");

            } //else {
                //System.out.println("this isn't working");
                //System.out.println(Menu1);
           // }
            else if (Menu1.equals("no")){
                Menu1 = "no";
                System.out.println("thanks for using  a banking application");
                break;
            }
            System.out.println(" do you want to do anything else?, if no type lowercase no");

            Menu1 = scnr.next();
        }while(Menu1 != "no");
  /*Record.setidNumber(12);
  Record.getidNumber();
  Record.setcurrentChecking(520);
  Record.getcurrentChecking();
  Record.setcurrentSavings(123);
  Record.getcurrentSavings();
  Record.setpercentage(.007);
  Record.getpercentage();
  Record.setName("Bob_man_here");
  Record.getName();*/
    }

}

