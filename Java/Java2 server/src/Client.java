import java.io.*;
import java.net.*;

public class Client {
    public static void main(String[] args) {
        final String Host = "localhost";
        Socket clientSocket = null;
        BufferedReader reader1 = null;
        BufferedWriter writer1 = null;

        try {
            clientSocket = new Socket(Host, 7777);
            writer1 = new BufferedWriter(new OutputStreamWriter(clientSocket.getOutputStream()));
            reader1 = new BufferedReader(new InputStreamReader((clientSocket.getInputStream())));

            writer1.write("7.7");
            writer1.newLine();
            writer1.flush();
            writer1.write("0.7");
            writer1.newLine();
            writer1.flush();
            writer1.write("9.9");
            writer1.newLine();
            writer1.flush();
            writer1.write("QUIT");
            writer1.newLine();
            writer1.flush();
            String respondLine;
            while ((respondLine = reader1.readLine()) != null) {
                System.out.println("Server: " + respondLine);
                if (respondLine.indexOf("OK") != -1) {
                    break;
                }
            }
            writer1.close();
            reader1.close();
            clientSocket.close();
        } catch (UnknownHostException e) {
            System.out.println("An Unknown host " + Host);
            System.out.println(e.getMessage());
        } catch (IOException e) {
            System.out.println("you triggered an IO exception" + Host);
            System.out.println(e.getMessage());
        }

    }
}
