//week five assignment
// c++ 1
// Gabriel Lackie
// sorry for some reason i absolutely cannot get eclispe to work i cant make my compiler work
#include <iostream>
#include <string>
#include <vector>
#include "Header.h"
using namespace std;

float main() {
    // performing gas prices assignment part
    // std::cout << "Hello World!\n";
    float RegularPrice;
    std::cout <<  " enter a gas price for Regular\n";\
    std::cin >> RegularPrice;
    float MidGrade;
    std::cout << "enter a gas price for Mid-Grade\n";
    std::cin >> MidGrade;
    float Premium;
    std::cout << "enter a gasprice for Premium\n";
    std::cin >> Premium;
    float GasPrices[]{ RegularPrice, MidGrade, Premium };
    std::cout << "your price for regular is " << RegularPrice;
    std::cout << " you entered " << MidGrade << " for your Mid-Grade Price\n";
    std::cout << " you used " << Premium << " as your Premium price\n";
    float gas = 15;
    float calculateReg = gas * RegularPrice;
    float calculateMid = gas * MidGrade;
    float calculatePremium = gas * Premium;

    std::cout << "if you wanted to fill a 15 dollar gas tank\n";
    std::cout << " you would be spending " << calculateReg << " if you chose Regular gas\n";
    std::cout << "if you used Mid-Grade to fill 15 gallons, you would spend " << calculateMid << " to fill a 15 dollar gas tank\n";
    std::cout << calculatePremium << " is what you would spend if you were filling 15 gallons with Premium\n";
    vector <int> watsup;
    int number;
    string no;
    // this is me trying to perform the vector.
    int count = 0;
    while (no != "n") {
        
        std::cout << "watsup? tell me your favorite number!";
        std::cin >> number;
        watsup.push_back(number);
        std::cout << "enter lowercase n to quit or press a random letter to continue";
        std::cin >> no;
        cout << " you  entered " << watsup[count]<< "\n";
        count = count + 1;
    }
    cout << " the first number you entered is\n" << watsup[0];
    int pet;
    cout << " how many pets do you have?\n";
    cin >> pet;
    cout << pet;
    string pets;
    static string petnames[9999];
    for (unsigned int i = 0; i < pet; i++) {
       cout << " what is your pets name?\n";
       cin >> pets;
       petnames[i] = pets;
       cout << pets << " has been added to the the array\n";

    }
   cout << " the name of your first pet is " << petnames[0] << "\n";
   cout << " testing a void function \n";
   Pizza();
   cout << "testing a return function that returns a value\n";
   int myage = HowOldAreYou(8);
   cout << "the value returned by function HowOldAreYou is " << myage << "\n";
}


