// Final Project: Banking Application
// Project Week: ThanksGiving
//File Page
//Java Class
// Gabriel Lackie
//import java.util.Scanner;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;
public class File {
    static String file = "clientFile.txt";
    private Scanner scnr;
    ArrayList<Record> FileArray = new ArrayList<>();
    //input input34 = new input(scnr);
    //bArrayList<Record> fileArray =  input34.Process();
    public File(){
        FileArray.add(new Record(111, "John", 30, 30, .05));
        FileArray.add(new Record(112, "Wayne", 500, 725, .1));
        FileArray.add(new Record(113, "Vader", 1000, 800, .07));
        FileArray.add(new Record(114, "Gandalf", 100, 150, .09));
        FileArray.add(new Record(115, "Bilbo", 300, 267, .05));
        FileArray.add(new Record(116, "JackSparrow", 0,0,.78));
        FileArray.add(new Record(117, "LongJohnSilver", 5000, 1500, .50));
    }


    public ArrayList<Record> Read() throws NumberFormatException {
        Record NewRecord = new Record();
        String input = " ";
        String [] array ;
        String Name;
        int idNumber;
        Double currentChecking;
        Double percentage;
        Double currentSavings;

        try  {
            System.out.println("attempting to read your files");
            FileInputStream fileByteStream = new FileInputStream(file);
            Scanner inFS = new Scanner (fileByteStream);

            while (inFS.hasNextLine()){
                input = inFS.nextLine();
                array = input.split(",");
                idNumber = Integer.parseInt(array[0]);
                Name = array[1];
                currentChecking=Double.parseDouble(array[2]);
                currentSavings=Double.parseDouble(array[3]);
                percentage= Double.parseDouble(array[4]);
                // System.out.println("Id " + idNumber + " Name " + Name + " Current Checking $"+ currentChecking
                //  +" monthly rate "+ percentage  + " Current Savings $" + currentSavings);
                FileArray.add(new Record(idNumber, Name, currentChecking, currentSavings, percentage));
                //FileArray.add(NewRecord);
            }
            inFS.close();
            System.out.println("congratulations, your files have been read!");
        }

        catch(IOException ioException) {
            System.out.println(" there was an io exception error in file class" +
                    "in the read method");
            write(FileArray);

            //return Read();

        }

        return FileArray;

    }

    public Record Read(int index) {

        System.out.println("attempting read a file at a specific index");
        ArrayList<Record> readmeArray = Read();
        try{
            return readmeArray.get(index);
        }
        catch (Exception e){
            System.out.println("apologies, our system has failed to find that file," +
                    "an error has occurred in our File page in the Read Index method.");

            return new Record();
        }



    }
    public int write(ArrayList<Record> FileArray) {
        System.out.println("Our Banking System is attempting to Update your account" +
                "and write it to our Clients File");
        if(FileArray.size()==0){ System.out.print("no client data to return");return -1;}
        FileOutputStream fileStream = null;
        PrintWriter outFS = null;
        Record NewRecord;
        try {
            fileStream = new FileOutputStream(file);
            outFS = new PrintWriter(fileStream);

            for (int i = 0; i < FileArray.size(); ++i) {
                NewRecord = FileArray.get(i);
                outFS.print(Integer.toString(NewRecord.idNumber) + ",");
                outFS.print(NewRecord.Name + ",");
                outFS.print(Double.toString(NewRecord.currentChecking) + ",");
                outFS.print(Double.toString(NewRecord.currentSavings) + ",");
                outFS.println(Double.toString(NewRecord.percentage));

            }
            outFS.close();

        }

        catch (IOException ioException){
            System.out.println("We are Sorry, our System has Failed to update your account" +
                    "and write your data into our File Section");
            return -1;
        }
        outFS.close();
        return FileArray.size();
    }







}
