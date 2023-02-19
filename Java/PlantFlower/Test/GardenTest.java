import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;
import static org.junit.jupiter.api.Assertions.assertFalse;

class GardenTest {

    /******************************************************
     * Test default constructor for plant
     *****************************************************/

    @Test
    public void testPlantConstructor() {
        Plant p = new Plant();
        assertEquals("No Name", p.getPlantName() );
        assertEquals( 0.0, p.getPlantCost(), 0.1 );
    }


    /******************************************************
     * Test default constructor for flower
     *****************************************************/

    @Test
    public void testFlowerConstructor() {
        Flower f = new Flower();
        assertEquals("No Name", f.getPlantName() );
        assertEquals( 0.0, f.getPlantCost(), 0.1 );
        assertFalse(f.getPlantType());
        assertEquals( "TBD", f.getColorOfFlowers() );
    }

    /******************************************************
     * Test setters for Plant
     *****************************************************/

    @Test
    public void testPlantSetters() {
        Plant p = new Plant();

        p.setPlantName("Apple Tree");
        p.setPlantCost(50.99);

        assertEquals("Apple Tree", p.getPlantName() );
        assertEquals( 50.99, p.getPlantCost(), 0.1 );
    }

    /******************************************************
     * Test setters for Flower
     *****************************************************/

    @Test
    public void testFlowerSetters() {
        Flower f = new Flower();
        f.setPlantName("Rose");
        f.setColorOfFlowers("Red");
        f.setPlantType(true);

        assertTrue(f.getPlantType());
        assertEquals( "Red", f.getColorOfFlowers() );
    }

    /******************************************************
     * Test Garden Manager Constructor
     *****************************************************/
    @Test
    public void testGardenManagerConstructor() {

        Garden list = new Garden();
        assertEquals( 0, list.getMyGardenList().size());
    }


    /******************************************************
     * Test Adding plants and flowers to My Garden
     *****************************************************/
    @Test
    public void testAddingPlantsAndFlowers() {

        Garden list = new Garden();
        Plant p = new Plant();
        p.setPlantName("Spirea");
        p.setPlantCost(10.0);

        Flower f = new Flower();
        f.setPlantName("Rose");
        f.setPlantCost(6.0);
        f.setPlantType(false);
        f.setColorOfFlowers("White");

        list.addPlant(p);
        list.addPlant((Plant) f);
        assertEquals( 2,list.getMyGardenList().size());
    }
}