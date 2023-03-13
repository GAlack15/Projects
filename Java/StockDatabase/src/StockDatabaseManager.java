import java.util.ArrayList;

public class StockDatabaseManager {
    public static void main(String[] args) {
        StockDatabase stockDataBase = new StockDatabase();

        stockDataBase.readStockData("data/stock_data.csv");

        print(stockDataBase);
    }

    public static void print(StockDatabase variable){
        // For each loop
        for(StockEntry stockEntry : variable.getStockEntries()){
            System.out.println(stockEntry);
        }

//        // The equivalent for loop
//        for(int i = 0; i < variable.countRecords(); i++){
//            System.out.println(variable.getStockEntries().get(i));
//        }
    }
}
