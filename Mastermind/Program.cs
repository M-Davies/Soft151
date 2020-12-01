using System;

namespace Assignment
{
    class Program
    {
        ///=========================================================================================
        ///N = NUMBER OF POSITIONS
        ///M = RANGE OF COLOURS/VALUES
        ///secret = RANDOMLY CREATED SECRET CODE               
        ///guess = DIGIT ENTERED BY THE USER FOR THEIR GUESS
        ///guessCount = MAXIMUM NUMBER OF GUESSES ALLOWED BEFORE THE ATTEMPT IS CONSIDERED A FAILURE 
        ///correctGuesses = THE AMOUNT OF BLACK PINS THAT HAVE BEEN CREATED
        ///guessHistory = THE RECORD OF ALL THE GUESSES MADE BY THE USER
        ///blackFound = RECORDS THE AMOUNT OF BLACKS FOUND IN THE GUESS ARRAY  
        ///whiteFound = RECORDS THE AMOUNT OF WHITES FOUND IN THE GUESS ARRAY
        ///indexCount = ENSURES THAT ELEMENTS IN THE GUESS HISTORY ARE NOT OVERWRITTEN
        ///=========================================================================================
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("-----------WELCOME TO MASTERMIND!-----------");
            Console.WriteLine("********************************************");

            //Continue playing while the user is answering yes. 
            do
            {
                PlayGame();

                Console.Write("Play again? (Y/N)");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }

        private static void PlayGame()
        {
            //Declare N and M and obtain max guesses. 
            int N = GetN();
            int M = GetM();                                    
            int guessCount = GetMaxGuesses();
            
            ///Create secret code.
            Random randomSecret = new Random();

            int[] secret = new int[N];

            //Creates random secret code of N length and with values varying between 1 and M.
            for (int i = 0; i < N; i++)
            {
                secret[i] = randomSecret.Next(1, M);
            }

            ///User makes a guess and is evaluated.
            //Declare.
            int[] guess = new int[N];
            int[] guessHistory = new int[guessCount * N];
            bool[] blackFound = new bool[N];
            bool[] whiteFound = new bool[N];
            int correctGuesses = 0;            
            int indexCount = -N; //Variable is a minus as the guess.CopyTo() method needs to start at the first item (i.e. 0).

            do
            {
                for (int i = 0; i < N; i++)
                {
                    //If the secret code has been broken, break out of the input loop.
                    if (correctGuesses >= 4)
                    {
                        break;
                    }

                    Console.WriteLine("Please enter a guess digit");
                    Console.WriteLine("**************************");

                    //Checks that the input is a number. If not, revert to the default value. 
                    try
                    {
                        guess[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR! Entered value is not a number, your digit has been automatically set to 1.");
                        guess[i] = 1;
                    }
                    indexCount++; //Keeps count of how many index guesses have been made.
                }

                //Copy out the guess to be stored and displayed at the end of the game.
                guess.CopyTo(guessHistory, indexCount);

                //Keeps track of the number of guesses made and sets the evaluation arrays to false.
                guessCount = guessCount - 1;
                SetFalse(ref blackFound, N);
                SetFalse(ref whiteFound, N);

                //Evaluate Guess.
                for (int i = 0; i < N; i++) //Check through array.
                {
                    correctGuesses = 0;
                    if (guess[i] == secret[i]) //If guess is the right value and in the same position.
                    {
                        blackFound[i] = true;
                        continue;
                    }
                    for (int j = 0; j < N; j++) //Check again...
                    {
                        if (guess[i] == secret[j] && blackFound[j] == false && whiteFound[j] == false) //...for the right value, wrong position.
                        {
                            whiteFound[j] = true;
                            break;
                        }
                    }
                }

                //Count the pins.
                int black;
                int white;
                black = BoolCount(N, blackFound);
                white = BoolCount(N, whiteFound);

                //Show current guess.
                Console.Write("Your guess was: ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("[" + guess[i] + "]");
                }
                Console.WriteLine();

                //Display black pins.
                for (int i = 0; i < black; i++)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("BLACK PIN");
                    Console.WriteLine("********************");
                    correctGuesses++;
                }

                //Display white pins.
                for (int i = 0; i < white; i++)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("WHITE PIN");
                    Console.WriteLine("********************");
                }               

                //Show remaining guesses.
                Console.WriteLine(guessCount + " guesses remaining!");                
            }
            while (guessCount > 0 && correctGuesses < N); //End do-while if the user runs out of guesses or the secret is correctly guessed.

            ///Player wins the game if N black pins are present. Show guess history and secret code.
            if (correctGuesses >= N)
            {
                GuessHistoryAndSecretCode(N, guessHistory, secret); //Display the guess history.
                
                Console.WriteLine("CONGRATULATIONS! YOU HAVE BEATEN THE COMPUTER WITH {0} GUESSES REMAINING!!!!", guessCount);                
                Console.WriteLine("PLEASE SEE THE HISTORY OF YOUR GUESSES ABOVE.");                
                Console.WriteLine("*************************************************");
            }

            ///Player loses the game if they run out of guesses and haven't correctly guessed the code. Show guess history and secret code.
            if (guessCount <= 0 && correctGuesses < N)
            {
                GuessHistoryAndSecretCode(N, guessHistory, secret); //Display the guess history.
                
                Console.WriteLine("YOU HAVE BEEN DEFEATED BY THE COMPUTER!");                
                Console.WriteLine("PLEASE SEE THE HISTORY OF YOUR GUESSES ABOVE.");
                Console.WriteLine("*************************************************");
            }
        }

        private static void GuessHistoryAndSecretCode(int N, int[] guessHistory, int[] secret) //Displays the guess history and secret code at the end of the game
        {
            int digitCount = 0; //This is the digit in guessHistory that is currently being printed.
            int guessNumber = 1; //This is the guess number that the digit is attached to.

            Console.WriteLine("********************");
            Console.WriteLine("GUESS {0}:", guessNumber);
            guessNumber++;

            foreach (var history in guessHistory) //Run through the guessHistory array.
            {
                if (digitCount == N) //If the first guess has already been displayed...
                {
                    //...Move onto the next guess.
                    Console.WriteLine("GUESS {0}:", guessNumber);
                    guessNumber++;
                    digitCount = 0;
                }
                Console.WriteLine(history.ToString());
                digitCount++;
            }

            //Display the secret code.
            Console.Write("THE SECRET CODE WAS: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("[" + secret[i] + "]");
            }

            Console.WriteLine("\n*************************************************");
        }
        private static int BoolCount(int N, bool[] totalPins) //Creates the array for counting the pins.
        {            
            int total = 0;
            for (int i = 0; i < N; i++) //Runs through the array.
            {
                if (totalPins[i])
                {
                    total++; //Add 1 to total.
                }
            }
            return total;
        }
        private static int GetN() //Obtains number of positions from the user.
        {
            int N;
            try
            {
                Console.Write("How many positions would you like to have?:");
                N = Convert.ToInt32(Console.ReadLine());
                return N;
            }
            catch (FormatException)
            {
                //Return default value if the input entered isn't an integer.
                Console.WriteLine("ERROR! Entered value is not a number. Default value 6 has been chosen automatically.");
                return 6;
            }
        }
        private static int GetM() //Obtains the range of numbers in use from the user.
        {
            try
            {
                int M;
                Console.Write("How many numbers?:");
                M = Convert.ToInt32(Console.ReadLine());
                return M;
            }
            catch (FormatException)
            {
                //Return default value if the input entered isn't an integer. 
                Console.WriteLine("ERROR! Entered value is not a number. Default value 6 has been chosen automatically.");
                return 6;
            }
        }
        private static int GetMaxGuesses() //Obtains the maximum number of guesses allowed from the user.
        {
            try
            {
                int maxGuesses;
                Console.Write("What is the maximum amount of guesses allowed?:");
                maxGuesses = Convert.ToInt32(Console.ReadLine());
                return maxGuesses;
            }
            catch (FormatException)
            {
                //Return default value if the input entered isn't an integer. 
                Console.WriteLine("ERROR! Entered value is not a number. Default value 12 has been chosen automatically.");
                return 12;
            }
        }
        private static void SetFalse(ref bool[] pinArray, int N) //Sets the black and white found arrays to false.
        {            
            for (int i = 0; i < N; i++)
            {
                pinArray[i] = false;
            }
        }
    }
}