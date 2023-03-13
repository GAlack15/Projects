import java.io.*;
import java.util.*;

public class StockDatabase {
    private final ArrayList<StockEntry> stockEntries;

    public StockDatabase() {
        stockEntries = new ArrayList<>();
    }


    public ArrayList<StockEntry> getStockEntries() {
        return stockEntries;
    }

    public int countRecords() {
        return stockEntries.size();
    }

    public void readStockData(String fileName) {
        try {
            File readFile = new File(fileName);
            BufferedReader reader = new BufferedReader(new FileReader(readFile));
            String contents;
            while ((contents = reader.readLine()) != null) {
                String[] strings = contents.split(",");

                if (!strings[0].equalsIgnoreCase("date")) {
                    String date = strings[0];
                    Double open = Double.parseDouble(strings[1]);
                    Double high = Double.parseDouble(strings[2]);
                    Double low = Double.parseDouble(strings[3]);
                    Double close = Double.parseDouble(strings[4]);

                    StockEntry stockEntry = new StockEntry(date, open, high, low, close);
                    stockEntries.add(stockEntry);
                }
            }
        } catch (IOException IO) {

        }

    }
}
