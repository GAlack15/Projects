#pragma once
#ifndef Header_H_
#define Header_H_
#endif

#include <iostream>
#include <string>
#include <vector>
void Pizza() {
    std::cout << "want to order some pizza man ? \n";
    std::cout << " oh this is a void function by the way\n";
}

int HowOldAreYou(int age) {
    std::cout << "this program has a defualt age of 8 entered, ";
    std::cout << " enter an age for how old you are...\n";
    std::cin >> age;
    
    if (age > 70) {
        std::cout << " you are old\n";
    }
    else if (age > 20) { std::cout << " you are old enough to drink Alchohol, drink responsibly\n"; }

    else if (age > 17) { std::cout << " you are the legal minimum voting age, congrats\n"; }

    else if (age < 18) { std::cout << " you are young, want a candy?\n"; }
    else {
        std::cout << "I dont know what you entered for age.. i'm just a computer program\n";
    }
    return age;
}