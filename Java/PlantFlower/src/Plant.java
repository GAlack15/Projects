import java.text.DecimalFormat;
/****************************************************
 * @author  Gabriel Lackie
 ****************************************************/
public class Plant {
    String plantName;
    double plantCost;
    boolean plantType;

    public Plant() {
        plantName = "No Name";
        plantCost = 0;
        plantType = false;
    }

    public String getPlantName() {
        return plantName;
    }

    public double getPlantCost() {
        return plantCost;
    }

    public void setPlantName(String plantName) {
        this.plantName = plantName;
    }

    public void setPlantCost(double plantCost) {
        this.plantCost = plantCost;
    }

    public void setPlantType(boolean plantType) {
        this.plantType = plantType;
    }

    public boolean getPlantType() {
        return plantType;
    }

    public void printInfo(){
        System.out.println("Plant Information:");
        System.out.println("    Plant name: " +  plantName);

        DecimalFormat dc = new DecimalFormat("##");
        System.out.println("    Cost: " + dc.format(plantCost));
    }
}
