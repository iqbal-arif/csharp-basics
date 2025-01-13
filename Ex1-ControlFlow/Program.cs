namespace Ex1_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Excercise 1:
             //Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display \'Valid\' on the console. Otherwise, display \'Invalid\'. (This logic is used a lot in applications where values entered into input boxes need to be validated.


            string userInput;

            do
            {
                Console.Write("Please enter a number (or 'x' to exit): ");
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }

                else if (userInput.ToLower() != "x" && !int.TryParse(userInput, out _))
                { 
                                            
                            Console.WriteLine("Please enter a valid number or 'x' to exit.");
                }

            } while (string.IsNullOrEmpty(userInput) || (userInput.ToLower() != "x" && !int.TryParse(userInput, out _)));


            if (userInput.ToLower() == "x")
            {
                Console.WriteLine("Program Terminated.");
            }
            else
            {
                int enteredNum = Int32.Parse(userInput);

                if ((enteredNum > 0) && (enteredNum < 11)) 
                {
                    Console.WriteLine($"Your Valid number is: {userInput}");

                }
                else
                {
                    Console.WriteLine(@"Sorry you entered number that was not between 1 and 10!!
Thanks for trying.

Come back again.");
                }
                return;
            }



        }
    }
}