import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
    public static void main(String args[]) {
        ServerSocket listener = null;
        String line;
        BufferedReader ls;
        BufferedWriter os;
        Socket socketOfServer = null;

        try {
            listener = new ServerSocket(7777);

            System.out.println("Server is waiting to accept user...");
            socketOfServer = listener.accept();
            System.out.println("Accept a client");
            ls = new BufferedReader(new InputStreamReader(socketOfServer.getInputStream()));
            os = new BufferedWriter(new OutputStreamWriter(socketOfServer.getOutputStream()));
            while (true) {
                line = ls.readLine();
                os.write(">> " + line);
                os.newLine();
                os.flush();
                if (line.equals("QUIT")) {
                    os.write(">> OK");
                    os.newLine();
                    os.flush();
                    break;
                }
                double radius = Double.valueOf(line);
                double area = radius * radius * 3.14;
                os.write("circle has an area of " + area + " and also has a radius of " + radius);
                os.newLine();
                os.flush();
            }

            System.out.println("Server is no longer running");
        } catch (IOException e) {
            System.out.println(e);
            System.out.println("The Catch Statement was Run");
            System.exit(1);
        }

    }
}
