import java.io.File;
import java.util.Scanner; // Import the Scanner class to read text files

// This was Written by Gabriel Lackie
// Java CIS 217
public class App {
    public static void main(String[] args) {
        Thread t1 = new MyThread1();
        Thread t2 = new MyThread2();
        Thread t3 = new MyThread3();

        t1.start();
        t2.start();
        t3.start();
    }
}

class MyThread1 extends Thread {
    public void run() {
        try {
            File myObj = new File("data/FileA.txt");
            Scanner myReader1 = new Scanner(myObj);
            while (myReader1.hasNextLine()) {
                String data = myReader1.nextLine();
                System.out.println(data);
                sleep(2000);
            }

        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
    }
}

class MyThread3 extends Thread {
    public void run() {
        try {
            File myObj = new File("data/FileB.txt");
            Scanner myReader1 = new Scanner(myObj);
            while (myReader1.hasNextLine()) {
                String data = myReader1.nextLine();
                System.out.println(data);
                sleep(2000);
            }

        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
    }
}

class MyThread2 extends Thread {
    public void run() {
        try {
            File myObj = new File("data/File100.txt");
            Scanner myReader1 = new Scanner(myObj);
            while (myReader1.hasNextLine()) {
                String data = myReader1.nextLine();
                System.out.println(data);
                sleep(2000);
            }

        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
    }
}
