namespace MidtermBonus;
class RockPaperScissors {
   static void Main() {
        HumanPlayer p1 = new HumanPlayer(5);
        // constuctor and pass a parameter to constructor to set value of points to 5
        ComputerPlayer p2 = new ComputerPlayer();
        while (p1.GetPoints() > 0) {
            // p1.GetPoints() > 0 because we want to end the game(while loop) when human player has 0 points
            Console.WriteLine("****Rock Paper Scissors, Start!!****");
            Console.WriteLine($" Your points: {p1.GetPoints()}");
            // first time p1.GetPoints() is called the inital value is set, future p1.GetPoints() is called & "points" is updated(+\-)
            string p1Decision = p1.HumanDecision();
            string p2Decision = p2.ComputerDecision();
            Console.WriteLine($"--> Your Decision: {p1Decision}");
            Console.WriteLine($"--> Computer's Decision: {p2Decision}");
            // tie:
            if (p1Decision == p2Decision) {
                Console.WriteLine("Tie");
            }
            // human win round:
            else if (p1Decision=="rock" && p2Decision=="scissors" ||
                p1Decision=="paper" && p2Decision=="rock" ||
                p1Decision=="scissors" && p2Decision=="paper") {
                Console.WriteLine("You Win!");
                p1.WinRound();
            }
            // human lose round:
            else {
                Console.WriteLine("You Lose!");
                p1.LoseRound();
            }
            Console.WriteLine("--> Play again? Input y to continue, or n to exit: ");
            // play again:
            string playAgain = Console.ReadLine().ToLower();
            while (playAgain != "y" && playAgain != "yes" && playAgain != "n" && playAgain != "no") {
                Console.WriteLine("Invalid input try again");
                playAgain = Console.ReadLine().ToLower();
            } // while loop to check for invalid inputs

            // if human does not want to play agiain:
            if (playAgain != "y" && playAgain != "yes") {
                break;
            }
            // if had enough points then lost:
            else if (p1.GetPoints() == 0) {
                Console.WriteLine("Sorry, you don't have enough points, thanks for playing.");
            } // shows the message then starts while loop again & will not run because must be p1.GetPoints() > 0 to run while loop 
        }
        // Game Over:
        Console.WriteLine("Thank you for playing!");
        // shows message when while loop ends (when human does not have enough points and also when human chooses not to play again)
   }
}

class HumanPlayer{
    private int points;
    // the points that the human player has- users can't change b/c private so must use GetPoints() to call
    public HumanPlayer(int initial){ 
        points = initial;
    } // contructor used to set player's initial points and allows for use in object to pass parameter to constructor for intitial points
    public int GetPoints(){
        return points;
    } // return the points of the human player; GetPoints is used to call points since points is private
    public void WinRound(){
        points = points + 5;
    } // human player increases 5 points
    public void LoseRound(){
        points = points - 5;
    } // human player decreases 5 points 
    public string HumanDecision() {
        Console.WriteLine("Please input your choice: rock, paper, or scissors:");
        string decision = Console.ReadLine().ToLower();
        // use .ToLower to convert human input to lowercase so it can be compared to computers input
        while (decision != "rock" && decision != "paper" && decision != "scissors") {
            Console.WriteLine("Invalid decision. Try again: ");
            decision = Console.ReadLine().ToLower();
        } // while checks if human input is valid(otherwise invalid choices(typos) will always "lose"(-5points) when compared against computer's choice) 

        return decision; 
    }   // returns human input- stores & updates the human input to be used for comparison
}

class ComputerPlayer{
    public string ComputerDecision(){
        Random rnd = new Random();
        // random select integer from 0, 1, 2
        int rnd_num = rnd.Next(0,3);
        // if statements to check:
        if (rnd_num == 0){
            return "rock";
        }
        if (rnd_num == 1){
            return "paper";
        }
        if (rnd_num == 2){
            return "scissors";
        }
        return "try again";
    }
}