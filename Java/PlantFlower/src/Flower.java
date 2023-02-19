/****************************************************
 * @author  Gabriel Lackie
 ****************************************************/
public class Flower extends Plant{
    String colorOfFlowers;

    public Flower() {
        colorOfFlowers = "TBD";
    }

    public String getColorOfFlowers() {
        return colorOfFlowers;
    }

    public void setColorOfFlowers(String red) {
        this.colorOfFlowers = red;
    }

    @Override
    public void printInfo(){
        super.printInfo();

        System.out.println("    Annual: "  + plantType);
        System.out.println("    Color of flowers: " + colorOfFlowers);
    }
}
