using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            room[,] myRooms = new room[5, 5];
            myRooms[0,0] = new room(0,0) { RoomDescription = "The entrance to the Dungeon is Dark and damp, and the door is rusted"};          
            myRooms[0,1] = new room(0, 1) { RoomDescription = " there is a fire nearby",
                 Goblin = new Enemies() {health = 3 }    };
            myRooms[0,2] = new room(0, 2) { RoomDescription = "you enter a large cave in the dungeon and torches light  wall," +
                " there is also a lake here",
                powerPotion = new powerUps() { potionhealth = 1}};
            myRooms[0, 3] = new room(0, 3) { RoomDescription = " you  swim to the other side of the lake and enter a new room, the room is built from old stone",
                Banshee = new Enemies() {health = 8 }
            };
            myRooms[0, 4] = new room(0, 4) { RoomDescription = " you enter a new room that is unfinished and leads to a steep cliff that you are unable to climb, as you look up it seems to have no end",
            HealthPotion = new powerUps() {potionhealth = 1 }
            };
            myRooms[1,0] = new room(1, 0) { RoomDescription = "you enter a hallway that's filled with rubble and coins",
            Orc = new Enemies() {health = 5 }
            };
            myRooms[1, 1] = new room(1, 1) { RoomDescription= " as you walk  into a new room you hear dripping water, and theres a soft light in the distance, in the shadows",
            Goblin = new Enemies() {health = 3 }
            };
            myRooms[1,2] = new room(1, 2){ RoomDescription = " your much closer to the light and you can feel the warmth coming off of it, however you smell Goblins",
            Goblin = new Enemies() { health = 3}
            };
            myRooms[1, 3] = new room(1, 3) { RoomDescription = "you found the source of the light, its a magic mirror that shows a bright, warm, field. unfortunately it's to big to carry",
            Goblin = new Enemies() { health = 3}
            };
            myRooms[1, 4] = new room(1, 4) {RoomDescription = "you enter a large area where a cliff that is too steep to climb remains, in the rubble by the cliff you Sacks of plundered magical treasure",
            Orc = new Enemies() { health = 5}
            };
            myRooms[2, 0] = new room(2,0) {RoomDescription = " you enter a Room thats filled with the smell of mushrooms, and some old bookshelves and chests sitting in the dark, there are no torches here",
            HealthPotion = new powerUps() {potionhealth = 1 }
            };
            myRooms[2, 1] = new room(2, 1) {RoomDescription = " you enter a dark room filled with chains and broken shields, theres also a burnt spellbook - its unreadable-",
            Banshee = new Enemies() { health = 8}
            };
            myRooms[2, 2] = new room(2, 2) {RoomDescription = " you enter the old mages high spell room, only all of the magic books are burnt, the staffs are snapped in two, and even the wizerds crown is crushed" +
                " the crystal ball is also shattered.",
            Orc = new Enemies() { health = 5}
            };
            myRooms[2, 3] = new room(2, 3) { RoomDescription = "you found the mages guards armoury, everything is toppled over and raided though some weapons still remain on the ground, again you smell mushrooms and fungus",
             Goblin = new Enemies() {health = 3 }
            };
            myRooms[2, 4] = new room(2, 4) { RoomDescription = " you find the back door to the dungeon, unfortunately the entrance is destroyed and has a baracade set to stop people from coming in or out",
             Banshee = new Enemies() { health = 1}
            };
            myRooms[3, 0] = new room(3, 0) {RoomDescription = " entering an empty room you find nothing of value, except for a  massive pile of mushrooms in barrels,  you rest a moment",
            };
            myRooms[3, 1] = new room(3, 1) {RoomDescription = "you hear loud noises ahead, and hide in another room, theres a chest that hasn't been pillaged yet",
            powerPotion = new powerUps() {potionhealth = 1 }
            };
            myRooms[3, 2] = new room(3, 2) {RoomDescription= " You found a sign saying Goblin territory, also you find an entrance to a deep cave",
            Goblin = new Enemies() { health = 3}
            };
            myRooms[3, 3]= new room(3, 3) { RoomDescription = " in the depths of the deep cave you see many broken mining pick axes, wizert is cold", 
            Orc = new Enemies() { health = 5 }
            };
            myRooms[3, 4] = new room(3, 4)
            {
                RoomDescription = " you leave the cave and notice that theres a staircase in the distance, but it looks old and withered, you see long scratch marks on the wall and find " +
                "long animal teeth on the floor",
            Banshee = new Enemies() {health = 8 }
            };
            myRooms[4, 0] = new room(4,0) {RoomDescription = "fighting your way through goblins you find and start climbing stairs, the Goblins fearfully flee from the new room and are unwilling to follow " +
                "stacks of coins litter the floor.",
            Banshee = new Enemies() { health = 8 }
            };
            myRooms[4, 1] = new room(4, 1) {RoomDescription = "you enter a room that has fresh air, but is cold and theres also a locked gate you cant open.",
                Banshee= new Enemies() {health = 8 }
            };
            myRooms[4, 2] = new room(4, 2) { RoomDescription = "the next room is also dark but there are broken bones and empty food barrels, the water in this room has gone bad, you hear a screech nearby",
            Banshee = new Enemies() {health = 8 }
            };
            myRooms[4, 3] = new room(4, 3) {RoomDescription= " you enter the one room that is nicer than the others, theres a carpet on the floor and theres shattered pots and vases and tall locked caste doors" +
                "you also see your first window and its black as night outside.  theres a staircase close by but wizert fears he's been followed",
            Banshee = new Enemies() { health = 8 }
            };
            myRooms[4, 4] = new room(4, 4) { RoomDescription = "after climbing a long staircase you have found the exit, you have won, with your new magical knowledge wizert departs casting a spell to prevent" +
                "future people from accidently wandering in the dungeon" };

            Wizert wizert = new Wizert(0, 0, 100, 200);
            room Description = myRooms[wizert.xPos, wizert.yPos];

           
            void wizertLocation()
            {
                if (wizert.xPos > 4)
                {
                    Console.WriteLine("you hit a wall");
                    wizert.xPos = wizert.xPos - 1;
                    Description.xPos = wizert.xPos - 1;
                   // Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
                   // Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
                }
                else if (wizert.xPos < 0)
                {
                    Console.WriteLine("you hit a wall");
                    wizert.xPos = wizert.xPos + 1;
                    Description.xPos= wizert.xPos + 1;
                   // Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
                   // Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
                }
                else if (wizert.yPos > 4)
                {
                    Console.WriteLine("you hit a wall");
                    wizert.yPos = wizert.yPos - 1;
                    Description.yPos = wizert.yPos - 1;
                   // Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
                   // Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
                }
                else if (wizert.yPos < 0)
                {
                    Console.WriteLine("you hit a wall");
                    wizert.yPos = wizert.yPos + 1;
                    Description.yPos= wizert.yPos + 1;
                    //Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
                    //Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
                }
                
                }
                void AttackGoblin()
            {
                if (Description.Goblin != null && Description.Goblin.health > 0)
                {
                    Console.WriteLine("you spot a Goblin!");
                    while (wizert.health > 0 && Description.Goblin.health > 0)
                    {
                        Console.WriteLine(" press a for attack, b for run away, and c for heal");
                        string attack = Console.ReadLine();
                        if (attack == "a")
                        {
                            Console.WriteLine("Goblin attacks and uses move 'Body Slam'! Wizert lose 2 health");
                            wizert.health = wizert.health - 2;
                            Console.WriteLine("wizert health is now " + wizert.health);
                            Console.WriteLine(" you choose to attach and use the spell 'FireBall' to attack the Goblin, the goblin loses 5 health");
                            Description.Goblin.health = Description.Goblin.health - 5;
                            wizert.magic = wizert.magic - 3;
                            Console.WriteLine("The spell costs 3 magic, wizert magic level is now " + wizert.magic);                          
                            Console.WriteLine(" Goblin health is now " + Description.Goblin.health);

                        }
                        else if (attack == "b")
                        {
                            Console.WriteLine("you use a Teleportation spell to flee back to the dungeon entrance.");
                            wizert.xPos = 0;
                            wizert.yPos = 0;
                            //Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
                            break;

                        }
                        else if (attack == "c")
                            {
                            if (wizert.magic > 0 & wizert.health < 100)
                            {
                                Console.WriteLine("you choose to heal yourself, - 5 magic");
                                wizert.magic = wizert.magic - 5;
                                wizert.health = wizert.health + 3;
                                Console.WriteLine("your magic lvl is now " + wizert.magic);
                            }
                            else { Console.WriteLine("you've exhausted your magical abilities"); }
                            }
                        }
                    }
                    //else { Console.WriteLine("there are no Goblins here"); }
                    }
            void AttackOrc()
            {
                if (Description.Orc != null && Description.Orc.health > 0)
                {
                    Console.WriteLine("You encounter a Dangerous Orc looting the dungeon treasure, he has a massive sword what do you do?");
                    while (wizert.health > 0 && Description.Orc.health > 0)
                    {
                        Console.WriteLine(" press a for attack, b for run away, and c for heal");
                        string attack = Console.ReadLine();
                        if (attack == "a")
                        {
                            Console.WriteLine("The Orc Attacks and chooses to use the move 'Cleave'  wizert lost 3 health");
                            wizert.health = wizert.health - 3;
                            Console.WriteLine("wizert health is now " + wizert.health);
                            Console.WriteLine(" you choose to Attack and use the spell 'FireBall' to attack the Orc, the Orc loses 5 health");
                            Description.Orc.health = Description.Orc.health - 5;
                            wizert.magic = wizert.magic - 3;
                            Console.WriteLine("The spell costs 3 magic, wizert magic level is now " + wizert.magic);
                            
                            Console.WriteLine(" Orc health is now " + Description.Orc.health);

                        }
                        else if (attack == "b")
                        {
                            Console.WriteLine(" You cast a teleportation spell to return to the Dungeon entrance.");
                            wizert.xPos = 0;
                            wizert.yPos = 0;
                            //Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
                            break;

                        }
                        else if (attack == "c")
                        {
                            if (wizert.magic > 0 & wizert.health < 100)
                            {
                                Console.WriteLine("you choose to heal yourself, - 5 magic");
                                wizert.magic = wizert.magic - 5;
                                wizert.health = wizert.health + 5;
                                Console.WriteLine("your magic lvl is now " + wizert.magic);
                            }
                            else { Console.WriteLine("you've exhausted your magical abilities"); }
                        }
                    }
                }
                //else { Console.WriteLine("there are no Orcs here"); }
            }

            void AttackBanshee()
            {
                if (Description.Banshee != null && Description.Banshee.health > 0)
                {
                    Console.WriteLine("Wizert encounters a Banshees, known for peircing crys and deep claws");
                    while (wizert.health > 0 && Description.Banshee.health > 0)
                    {
                        Console.WriteLine(" press a for attack, b for run away, and c for heal");
                        string attack = Console.ReadLine();
                        if (attack == "a")
                        {
                            Console.WriteLine("Banshee attacks and uses 'Screech' to Attack you! wizert lose 5 health");
                            wizert.health = wizert.health - 5;
                            Console.WriteLine("wizert health is now " + wizert.health);
                            Console.WriteLine("you choose to attack the Banshee with the spell 'FireBall', the Banshee loses 5 health");
                            Description.Banshee.health = Description.Banshee.health - 5;
                            wizert.magic = wizert.magic - 3;
                            Console.WriteLine("The spell costs 3 magic, wizert magic level is now " + wizert.magic);
                         

                            Console.WriteLine(" Banshee health is now " + Description.Banshee.health);

                        }
                        else if (attack == "b")
                        {
                            Console.WriteLine(" you cast a Teleportation spell to flee to the Dungeon entrance.");
                            wizert.xPos = 0;
                            wizert.yPos = 0;
                           // Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
                            break;

                        }
                        else if (attack == "c")
                        {
                            if (wizert.magic > 0 & wizert.health < 100 )
                            {
                                Console.WriteLine("you choose to heal yourself, - 5 magic");
                                wizert.magic = wizert.magic - 5;
                                wizert.health = wizert.health + 5;
                                Console.WriteLine("your magic lvl is now " + wizert.magic);
                            }
                            else { Console.WriteLine("you've exhausted your magical abilities"); }
                        }
                    }
                }
                //else { Console.WriteLine("you didn't find claw Marks in this room."); }
            }
            void PowerPotion() {
                if (Description.powerPotion != null && Description.powerPotion.potionhealth != 0) {             
                    Console.WriteLine("in an old chest, you find an old potion,");
                    Console.WriteLine(" using your enchantments, you use the potion and increase your magic level");
                wizert.magic = wizert.magic + 20;
                    Description.powerPotion.potionhealth = 0;

                }
            }
            void HealthPotion() {
                if (Description.HealthPotion != null && Description.HealthPotion.potionhealth != 0) {
                    Console.WriteLine("under broken rubble you find a potion, with a strange green liquid");
                    Console.WriteLine("while adding some herbs, you use an enchantment to consume the green potion and" +
                        " your health lvl goes up");
                    wizert.health = wizert.health + 10;
                    Description.HealthPotion.potionhealth = 0;
                }
            }

            void Dungeontext()
            {
                Console.WriteLine(Description.RoomDescription);

            }
            string UserNum;

            void TheEnd()
            {
                if (wizert.xPos == 4 & wizert.yPos == 4)
                {
                    if (Description.xPos == 4 & Description.yPos == 4)
                    {
                        Console.WriteLine("Congrats, you the Mighty Wizert has finished the game, re run the application to play again");
                        UserNum = "9";
                    }
                }
            }

            void death() { if (wizert.health < 1) {
                    wizert.xPos = 0;
                    wizert.yPos =0;
                    Console.WriteLine("sorry but Wizert's health has been depleted, you lose the game, Wizert will be returned to the entrance  with 30 health if you want to continue");
                    wizert.health = 30;
                } }
            // ask user a question.
            Console.WriteLine("You the all powerful Wizert sought out new magical knowledge");
            Console.WriteLine("Your healing abilities lvl up, however you cannot heal beyoned 100 hp");
            Console.WriteLine(" Mage powers level up!  you have aquired the spell 'FireBall' does 3 damage.");
            Console.WriteLine();
            Console.WriteLine("after successfully obtaining what you sought and completing the quest");
            Console.WriteLine("you find the only way to leave the Sorcerer's Tower, is to go through an old dungeon");
            Console.WriteLine(Description.RoomDescription);
            Console.WriteLine(" you have entered the dungeon and you cannot go back a wall closes behined you, do you want to go 1 for north, 2 for west,  3 for east, or 4 for south?");
           // Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            
             UserNum = Console.ReadLine();

            //// first if statement starts

            do
            {
               
                if (UserNum == "1")
              {
                    Console.WriteLine(" Wizert Moves up one space ");
                    wizert.yPos = wizert.yPos + 1;
                    Description.yPos = Description.yPos + 1;
                 
               }
                else if (UserNum == "2")
                {
                    Console.WriteLine(" Wizert Moves west one space ");
                    wizert.xPos = wizert.xPos - 1;
                    Description.xPos = Description.xPos - 1;
                   
                }
                else if (UserNum == "3")
                {
                    Console.WriteLine("Wizert moves one space to the east ");
                   wizert.xPos = wizert.xPos + 1;
                    Description.xPos = Description.xPos + 1;
                  
                }

             
                else if (UserNum == "4")
                {
               Console.WriteLine("Wizert moves one space to the south ");
                wizert.yPos = wizert.yPos - 1;
                Description.yPos = Description.yPos - 1;
                
                }

              
                
                wizertLocation();
                Description = myRooms[wizert.xPos, wizert.yPos];
                Dungeontext();
                AttackGoblin();
                AttackOrc();
                AttackBanshee();
                
                HealthPotion();
                PowerPotion();
                death();
                TheEnd();
                if (UserNum != "9")
                {
                    Console.WriteLine("do you want to go 1 for north, 2 for west, and 3 for east? or 4 for south?");
                    UserNum = Console.ReadLine();
                }
               
            } while (UserNum != "9");      
        }
    }
}
