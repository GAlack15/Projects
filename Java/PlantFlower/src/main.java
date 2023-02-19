import java.lang.*;
import java.util.ArrayList;
import java.util.Scanner;

/****************************************************
 * @author  Gabriel Lackie
 ****************************************************/

public class main {
    public static void main(String[] args) {
        ArrayList<Plant> myGarden = new ArrayList<>();

        Scanner scnr = new Scanner(System.in);

        String userInput = scnr.nextLine();
        while(!userInput.equals("-1")){
            String[] arrayOfStrings = userInput.split(" ");

            //["plant", "Spirea", "10"]
            //["flower", "Hydrangea", "30", "false", "lilac"]
            if(arrayOfStrings[0].equalsIgnoreCase("plant") ) {
                Plant plant = new Plant();
                plant.setPlantCost(Double.parseDouble(arrayOfStrings[2]));
                plant.setPlantName(arrayOfStrings[1]);
                myGarden.add(plant);
            }
            else {
                Flower plant = new Flower();
                plant.setPlantCost(Double.parseDouble(arrayOfStrings[2]));
                plant.setPlantName(arrayOfStrings[1]);
                plant.setPlantType(Boolean.parseBoolean(arrayOfStrings[3]));
                plant.setColorOfFlowers(arrayOfStrings[4]);
                myGarden.add(plant);
            }

            userInput = scnr.nextLine();
        }

        printArrayList(myGarden);
    }

    // step 2) create a method titled printArrayList()  that uses print info methods defined in respective classes.
    // method should print each element in myGarden
    //program should also read plants or flowers from input(ending with -1)
    // must add each Plant or FLower to the myGarden AraryList
    //add each Plant or Flower to the myGarden Arraylist
    //output each element using the printInfo method
    public static void printArrayList(ArrayList<Plant> myGarden) {
        for(Plant plant : myGarden) {
            plant.printInfo();
            System.out.println();
        }
    }
}
