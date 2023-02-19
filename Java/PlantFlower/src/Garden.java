import java.util.ArrayList;
/****************************************************
 * @author  Gabriel Lackie
 ****************************************************/
public class Garden {
    ArrayList<Plant> myGarden = new ArrayList<>();

    public void addPlant(Plant plant) {
        myGarden.add(plant);
    }

    public ArrayList<Plant> getMyGardenList() {
        return this.myGarden;
    }

    public void printArrayList() {
        for(Plant plant : myGarden) {
            plant.printInfo();
            System.out.println();
        }
    }
}

