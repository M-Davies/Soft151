//This is known as a “header file”
//In short, this copies and pastes the text file
//mbed.h into this code
#include "mbed.h"

#define kRED    1  
#define kYELLOW 2
#define kGREEN  4

//Digital Out objects used for ticker function
DigitalOut redLED(D7);
DigitalOut yellowLED(D6);
DigitalOut greenLED(D5);

BusOut binaryOutput(D7, D6, D5);    //Outputs as an integer

//The main function - all executable C / C++
//applications have a main function. This is
//out entry point in the software

//Instantiate flipper and voids to flip
Ticker flipper;

void flipYellow(){
		yellowLED = !yellowLED;
}

int main() {
    binaryOutput = 0;

    while(1) 
    {
        //STATE 1 (R) 
        binaryOutput = kRED;
        wait(1.0);
        
        //STATE 2 (RA)
        binaryOutput = kRED + kYELLOW;
        wait(1.0);
        
        //STATE 3 (G)
        binaryOutput = kGREEN;
        wait(1.0);
        
        //STATES 4-7 (Flashing A) - using Ticker flipper
				binaryOutput = 0; 									//Clear LEDS
        flipper.attach(&flipYellow, 0.25); 	//Ticker initialised to fire every 0.25 seconds (flips on/off)
				wait(4.0); 													//do this for 4 seconds
				flipper.detach(); 									//detach ticket and resume normal program            
    }

}