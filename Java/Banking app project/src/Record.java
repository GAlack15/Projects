//Record Page
//Java Class
// Gabriel Lackie

import java.util.ArrayList;
public class Record extends ArrayList<Record> {
    public int idNumber = -1;
    public String Name = " ";
    public double currentChecking = -1;
    public double  currentSavings = -1;
    public double percentage = -1;

    public Record (int idNumber, String Name, double currentChecking, double currentSavings, double percentage){
        this.idNumber = idNumber;
        this.Name = Name;
        this.currentChecking = currentChecking;
        this.percentage = percentage;
        this.currentSavings = currentSavings;
    }
    public Record () {
        idNumber = -1;
        Name = "";
        currentChecking = -1;
        percentage = -1;
        currentSavings = -1;
    }
    static double Deposit_withdrawl (double balance, double transaction){
        return balance + transaction;
    }
    static double Calculate_Interest(double interestRate, double amount) {
        if (amount > -1){

            return interestRate * amount;
        }
        else{
            System.out.println("your balance is in the negative so a zero is returned");
            return 0;
        }
    }

}
