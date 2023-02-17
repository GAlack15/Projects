// Final Project: Banking Application
// Project Week: ThanksGiving
//input Page
//Java Class
// Gabriel Lackie

import java.util.ArrayList;
import java.util.InputMismatchException;
import java.util.Scanner;

public class input {
    private Scanner scnr;
    File file = new File();
    ArrayList<Record> Clients = file.Read();


    public input(Scanner scnr) {
        this.scnr = scnr;
    }

    public void addClient() {
        //ArrayList<Record> array = file.Read();
        System.out.println("enter an ID Number");
        int var1 = scnr.nextInt();
        System.out.println("enter the Clients Name");
        String var2 = scnr.next();
        System.out.println("enter the amount to be deposited in checking");
        double var3 = scnr.nextDouble();
        System.out.println("enter an amount to be deposited in savings");
        double var4 = scnr.nextDouble();
        System.out.println("enter a percentage in decimal form");
        double var5 = scnr.nextDouble();
        // Clients.add(new Record(var1, var2, var3, var4, var5));
        Record Array = new Record();
        Array.idNumber = var1;
        Array.Name = var2;
        Array.currentChecking = var3;
        Array.currentSavings = var4;
        Array.percentage = var5;
        Clients.add(Array);

        file.write(Clients);

    }

    public void clientAccountDeposit(int client) {

        Record myClient = Clients.get(client);

        try {
            System.out.println("do you want to make a deposit or withdrawl?" +
                    "Press lowercase letter w for withdraw and lowercase d for deposit");
            String Wd = scnr.next();
            if (Wd.equals("w")) {
                System.out.println("your making a withdrawl do you want to withdraw" +
                        " from checking? or Savings?");
                System.out.print(" enter lowercase c for checking or lowercase s for savings");
                String CORS = scnr.next();
                if (CORS == "c") {
                    System.out.println("How Much do you want to withdraw from checking?");
                    double NoChecking = scnr.nextDouble();
                    myClient.currentChecking = Record.Deposit_withdrawl(myClient.currentChecking, NoChecking);
                    double negative = -1;
                    myClient.currentChecking = myClient.currentChecking * -1;
                    Clients.set(client, myClient);
                    file.write(Clients);
                    System.out.println("new balance is " + myClient.currentChecking);
                } else {
                    System.out.println("How much do you want to withdraw from Savings?");
                    double NoSavings = scnr.nextDouble();
                    myClient.currentSavings = Record.Deposit_withdrawl(myClient.currentSavings, NoSavings);
                    myClient.currentSavings = myClient.currentSavings * -1;
                    Clients.set(client, myClient);
                    file.write(Clients);
                    System.out.println(" new balance is " + myClient.currentSavings);

                }
            } else if (Wd.equals("d")) {
                System.out.println("your making a deposit! do you want to deposit funds" +
                        "into checking? or do you want to deposit funds into savings?");
                System.out.print(" enter lowercase c for checking or lowercase s for savings");
                String CORS = scnr.next();
                if (CORS == "c") {
                    System.out.println("please enter the amount you want to deposit to checking");
                    double YesChecking = scnr.nextDouble();
                    myClient.currentChecking = Record.Deposit_withdrawl(myClient.currentChecking, YesChecking);
                    Clients.set(client, myClient);
                    file.write(Clients);
                    System.out.println("new balance is" + myClient.currentChecking);
                } else {
                    System.out.println("please enter the amount you want to deposit to savings");
                    double YesSavings = scnr.nextDouble();
                    myClient.currentSavings = Record.Deposit_withdrawl(myClient.currentSavings, YesSavings);
                    Clients.set(client, myClient);
                    file.write(Clients);
                    System.out.println(" new balance is " + myClient.currentSavings);
                }

            }

        } catch (InputMismatchException q) {
            System.out.println("we Regret to inform you that your Transaction was not processed");
        }

    }

    public void InterestRate(int client) {
        Record InterestRate = Clients.get(client);
        double addme = Record.Calculate_Interest(InterestRate.percentage, InterestRate.currentSavings);
        System.out.println("your total monthly interest is $" + addme + " and will be added to your savings of $" + InterestRate.currentSavings);
        InterestRate.currentSavings = InterestRate.currentSavings + addme;
        Clients.set(client, InterestRate);
        file.write(Clients);

    }

}



