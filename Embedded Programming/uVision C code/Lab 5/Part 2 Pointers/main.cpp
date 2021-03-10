#include "mbed.h"

// Data structure describing a date and time.
typedef struct {
	int year;
	int month; // 0 (January) to 11 (December)
	int day; // (0 to 30)
	int hours;
	int minutes;
	int seconds;
} DateTime;

// CreateDateTime: modifies an existing variable 
// via a pointer, rather than returning a large structure.
void CreateDateTime(DateTime* dtToCreate)
{
	// Since dtToCreate is a pointer to a DateTime, need to use
	// -> to access its fields.
	dtToCreate->year = 2016;
	dtToCreate->month = 1; // February (zero-indexed)
	dtToCreate->day = 16; // 17th (zero-indexed)
	dtToCreate->hours = 18; // 6pm...
	dtToCreate->minutes = 57; // ... and 57 minutes...
	dtToCreate->seconds = 30; // ... and 30 seconds.
}	

// My version of CreateDateTime above
void PrintSafeDateTime(DateTime* dtToPrint, char* outputDate, int max)
{
	//Set date value
	snprintf(outputDate, max, "%d-%02d-%d %d:%d:%d", dtToPrint->year, dtToPrint->month,
		dtToPrint->day, dtToPrint->hours, dtToPrint->minutes, dtToPrint->seconds);
	
	//Print out to PuTTy
	printf("The time is = %s\r\n", outputDate);
}


// Main program function.
int main() {
	DateTime dt;
	
	char dateString[128];
	
	CreateDateTime(&dt);

	PrintSafeDateTime(&dt,dateString,sizeof(dateString));
	
	return 0;
}
