import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class StockDatabaseTest {
    /** object of the StockDatabase class */
    private StockDatabase database;

    /******************************************************
     * Test constructor
     *****************************************************/
    @Test
    public void testConstructor()
    {
        database = new StockDatabase();
        assertEquals(0, database.countRecords ());
    }

    /******************************************************
     * Test read file and counts
     *****************************************************/
    @Test
    public void testReadFileAndCounts()
    {
        database= new StockDatabase();
        database.readStockData("data\\stock_data.csv");
        assertEquals(61, database.countRecords ());
    }
}