#include <string.h>

// Function that converts a C-string to uppercase, then
// calculates the sum of all the ASCII values of the letters
// in the new upper-case string.
int UpperSum(const char* s)
{
	int i, sum;
	char tempStr[32];
	
	// Fill the temporary string with zeros (good practice).
	memset(tempStr, 0, sizeof(tempStr));
	
	// Copy the input string into a temporary local variable.
	// What could go wrong?!
	//strcpy(tempStr, s);
	strncpy(tempStr, s, sizeof(tempStr));
	
	// Convert the local string to uppercase.
	// Note: Characters between 97 and 122 are lowercase letters.
	//       Subtracting 32 from an lowercase letter makes it uppercase.
	for (i = 0; i < sizeof(tempStr); i++) {
		if (tempStr[i] >= 97 && tempStr[i] <= 122) {
			tempStr[i] = tempStr[i] - 32;
		}
	}
		
	// Calculate the sum of the uppercase letters.
	sum = 0;
	i = 0;
	for (i = 0; i < sizeof(tempStr); i++) {
		sum += tempStr[i];
	}
	
	return sum;
}

// Main program function.
int main()
{
	// String to calculate the sum of. This is the only line of code you
	// should change for part 1.
	//const char* inputStr = "test";																												//32 bytes for the word, then 12 bytes of numbers for the registers,																																													
	const char* inputStr = "suprcalfragilisticexpialidocious123456789012\xab\x02\x00\x08"; 	//then the memory address of SecretFunction (0x080002ab)
	
	// Calculate the sum.
	int val = UpperSum(inputStr);
	
	// Return calculated sum.
	return val;
}

// Super-secret inaccessible function that you're totally not able to call...
void SecretFunction()
{
	// Switch on the LED.
	unsigned int* RCC_AHB1ENBR = (unsigned int*)0x40023830;
	unsigned int* GPIOA_MODER = (unsigned int*)0x40020000;
	unsigned int* GPIOA_ODR = (unsigned int*)0x40020014;
	*RCC_AHB1ENBR |= (unsigned int)(1);
	*GPIOA_MODER |= (unsigned int)(1<<10);
	*GPIOA_ODR |= (unsigned int)(1<<5);
}
