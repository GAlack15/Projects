// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;



public class room {
    public Enemies Goblin;
    public Enemies Orc;
    public Enemies Banshee;
    public string RoomDescription = "";
    public powerUps powerPotion;
    public powerUps HealthPotion;
    public int xPos;
    public int yPos;

    public room( int xPos,int yPos) {
        this.xPos = xPos;
        this.yPos = yPos;
    }
    
}


public class Wizert
{
    public int xPos;
    public int yPos;
    public int health;
    public int magic;

    public Wizert(int xPos, int yPos, int health, int magic)
    {
        this.xPos = xPos;
        this.yPos = yPos;
        this.health = health;
        this.magic = magic;
    }

}

public class Enemies {
       
        public int health;
    public Enemies() {
        
        this.health = health;
    }
       
    }

        public class powerUps {
            private int healthPotion = 2;
            private int magickaPotion = 2;
           public int potionhealth = 0;
          
   
        }

