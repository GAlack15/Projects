// Final Project: Banking Application
// Project Week: ThanksGiving
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
    ArrayList<Record> records = new ArrayList<>();
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
        return interestRate * amount;
}
  /*  // getters
    public int getidNumber() {

        return idNumber;
    }
    public String GetName(){

        return Name;
    }
    public double getcurrentChecking(){

        return currentChecking;
    }
    public double getcurrentSavings(){

        return currentSavings;
    }
    public double getpercentage(){

        return percentage;
    }
    // setters
    public void setidNumber(int idNumber){

        this.idNumber = idNumber;
    }

    public void setName(String Name){

        this.Name = Name;
    }
    public void getName(){
        this.Name = Name;
    }
    public void setcurrentChecking(double currentChecking){
        this.currentChecking = currentChecking;
    }
    public void setcurrentSavings(double currentSavings){

        this.currentSavings = currentSavings;
    }
    public void setpercentage(double percentage){

        this.percentage = percentage;
    }
*/
}
