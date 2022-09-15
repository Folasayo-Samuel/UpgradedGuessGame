namespace GuessingGame.Code
{
	public class GuessGameCode
	{
		public static void GuessGameCod()
		{
			var secretWord = "giraffe";
			var guess = "";
			var guessCount = 0;
			var guessLimit = 2;
			var outOfGuesses = false;

            do
            {
                if (guessCount <= guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outOfGuesses = true;
                }
            } while (guess != secretWord && !outOfGuesses);
            if(outOfGuesses)
				Console.Write("You Lose!");
			else
				Console.Write("You Win!");


		}
	}
}