#include "mbed.h"
#include "math.h"
#include "rtos.h"
#include "string.h"
#include <stdio.h>

//Head and Tail of Circular Buffer
int tail = 0;
int head = 0;

//Functions
void RateChange();
void Sample();
void ButtonPressed();
void Authenticate();

//Inputs
AnalogIn AIN(A0);
InterruptIn button(D4);

//Ouputs
DigitalOut redLED(D7);
DigitalOut yellowLED(D6);
DigitalOut greenLED(D5);

//Globals/Constants
Serial pc(USBTX, USBRX);
#define MAXRATE 5 //Max size of user input sampling rate (2 decimal places)
#define MAXLENGTH 10 //Max size of username and password

Thread t1, t2;

char username[MAXLENGTH]; 


char sampleInput[5]; //Array to temporarily store user input
float fVin = 0.0; //Current Sample
float ReadingArray[10]; //Circular Buffer of Readings
volatile float sampleRate = 0.1; //Sample Rate
float currentRate = 0.1; //User Input

//Used to sign user in
char adminUsername[MAXLENGTH] = "admin";
char adminPassword[MAXLENGTH] = "password";
char password[MAXLENGTH];

//Function to get readings from potentiometer
void Sample()
{
	bool loopComplete = false;
	greenLED = 1;
   while(1) 
		 {
				if(greenLED == 0)
				{
					Authenticate(); //If button has been pressed, this can now execute
				}
				
      //Read ADC
      fVin = AIN;
			
			//Add value to current head
			ReadingArray[head] = fVin;
			if(head < 10)
				{
				head++; //Increment head
				if(loopComplete == true)
					{
					tail++; //Keep tail updated
						if(tail > 10)
						{
							tail = head - 1; //Decrement to prevent index overflow
						}
					}
				}
			else
				{ //Full loop complete
				head = 0;
				tail++; //Oldest value is updated
				loopComplete = true;	
				}
			
			//Count number of elements in array
			int elementCount = 0;
			float total = 0.00; 
			for (int i = 0; i < 10; i++)
				{
					if(ReadingArray[i] != NULL)
					{
						elementCount++;
						total = total + ReadingArray[i];
					}
				}
				
			//Calculate Average
			float average = total / elementCount;
				
			//Print out buffer
			printf("Sample Rate = %6.3f\n", sampleRate);
			printf("Circular Buffer [");
			for (int i = 0; i < 10; i++)
				{
					printf("%6.4f", ReadingArray[i]);
					printf("] [");
				}
			printf("END]\n");
			
			//Print out current sample and average
			printf("Current Sample is %6.4f. The average is %6.4f.\n\n", ReadingArray[head-1], average);
			wait(2);
				
			wait(sampleRate); //Rate of sampling
   } //end while(1)
}//end Sample()

//Function to change sampling rate
void RateChange()
{
	//Get user sample rate
	redLED = 1;
	printf("Sampling Stopped. Please enter a sample rate:");  
	fgets(sampleInput, MAXRATE, stdin); //fgets() safer than scanf() as it checks buffer size
	currentRate = strtof(sampleInput, NULL); //Copy safe user input across
	
	//Validation Check
	if(currentRate > 0 && currentRate <= 0.2)
	{
		sampleRate = currentRate; //User input is the new rate
		printf("%6.3f is the new sampling rate\n", sampleRate); 
	}
	else
	{
		printf("Error! Sample rate needs to be between 0.01 and 0.2\n");
		RateChange();
	}
	
	//Turn off LED and restart sampling
	redLED = 0;
	Sample();
}//end RateChange()

//Function to sign user in
void Authenticate()
{
	while(1) //Constantly checks condition
	{
		if(yellowLED == 1) //Button has been pressed
		{
			//Stop sampling
			t1.terminate();
			
			//Setup repeatability variable
			char tryAgain[2];
			strncpy(tryAgain, "Y", 1);
			
			//Get credentials (checking length of input)
			printf("Please enter admin username and password. Username:");
			fgets(username, 7, stdin);
			username[strcspn(username, "\n")] = '\0'; //Strip newline
				
			if(strncmp(adminUsername, username, strlen(adminUsername)) == 0) //If usernames...
			{
				printf("Password:");
				fgets(password, 10, stdin);
				password[strcspn(password, "\n")] = '\0'; //Strip newline
					
				if(strncmp(adminPassword, password, strlen(adminPassword)) == 0) //...and passwords...
				{
					yellowLED = !yellowLED; //Signals authentication is accepted
					RateChange(); //User can now change the sampling rate
				}
				else
				{
					printf("Incorrect Password!\n");
				}
			}
			else
			{
				printf("Incorrect Username!\n");
			}
		}//end if(yellowLED = 1)
	}//end while(1)
}//end Authenticate()

//ISR activated by button press
void ButtonPressed()
{
		yellowLED = 1; //Signals authentication thread to start
		greenLED = !greenLED; //Signals sampling thread to stop
} //end ButtonPressed()

//Main function
int main() {
	printf("Welcome to the SOFT261 Sampler!\n");
	
	t1.start(Sample); //Start sampling
	button.rise(ButtonPressed); //Intialise interrupt handler
	t2.start(Authenticate);
} //end main