import org.junit.*;
/****************************************************
 * MyGardenJUnitTest - To test Flower, Plant, and the Garden.
 *
 * @author  Resendiz
 * @version Feb 2021
 ****************************************************/

public class MyGardenJUnitTest {

    /******************************************************
     * Test default constructor for plant
     *****************************************************/
    @Test
    public void testPlantConstructor() {
        Plant p = new Plant();
        Assert.assertEquals("Plant should have a constructor that sets plant name to: No Name ", "No Name",
                p.getPlantName());
        Assert.assertEquals("Plant should have a constructor that sets plant cost to: 0.0 ", 0.0,
                p.getPlantCost(), 0.1);
    }


    /******************************************************
     * Test default constructor for flower
     *****************************************************/
    @Test
    public void testFlowerConstructor() {
        Flower f = new Flower();
        Assert.assertEquals("Flower should have called super and set plant name to: No Name ", "No Name",
                f.getPlantName());
        Assert.assertEquals("Flower should have called super and set plant cost to: 0.0 ", 0.0,
                f.getPlantCost(), 0.1);
        Assert.assertFalse("Flower should have a constructor that sets is Annual to false ", f.getPlantType());
        Assert.assertEquals("Flower should have a constructor that sets color of flower to TBD ", "TBD",
                f.getColorOfFlowers());
    }

    /******************************************************
     * Test setters for Plant
     *****************************************************/
    @Test
    public void testPlantSetters() {
        Plant p = new Plant();

        p.setPlantName("Apple Tree");
        p.setPlantCost(50.99);

        Assert.assertEquals("Plant's name should be: Apple Tree ", "Apple Tree",
                p.getPlantName());
        Assert.assertEquals("Plant's cost should be set to 50.99 ", 50.99,
                p.getPlantCost(), 0.1);
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

        Assert.assertTrue("Roses should be annual plants ", f.getPlantType());
        Assert.assertEquals("Roses should have color Red ", "Red",
                f.getColorOfFlowers());
    }

    /******************************************************
     * Test Garden Manager Constructor
     *****************************************************/
    @Test
    public void testGardenManagerConstructor() {

        Garden list = new Garden();
        Assert.assertEquals("The manager should create an empty ArrayList of Plants", 0, list.getMyGardenList().size());
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
        Assert.assertEquals("There should be two plants in the ArrayList", 2, list.getMyGardenList().size());
    }
}


