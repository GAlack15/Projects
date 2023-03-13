import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class StockEntryTest {
    /** object of the Stock Entry class*/
    private StockEntry s;

    /******************************************************
     * Test constructor
     *****************************************************/
    @Test
    public void testConstructor()  {
        //Testing a Stock Entry
        s = new StockEntry("04/01/21",15.50,17.50,14.50,16.50);

        assertEquals("04/01/21", s.getDate());

        assertEquals(15.50, s.getOpen(), 0.1);

        assertEquals(17.50, s.getHigh(), 0.1);

        assertEquals(14.50, s.getLow(), 0.1);

        assertEquals(16.50, s.getClose(), 0.1);

    }

}