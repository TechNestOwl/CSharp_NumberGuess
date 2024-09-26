/*********************************************************

   Gill Guimaraes

    Mini Project Part II - September 26, 2024

    Number Guessing Game

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //initializing guess counter
        int guessCounter = 0;


        //generate number 1 - 100
        int generatedNum;
        int generateRandomNum()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            System.Diagnostics.Debug.WriteLine(randomNumber);
            return randomNumber;
        }
        //button for generating a new number
        private void genNumButton_Click(object sender, EventArgs e)
        {
            generatedNum = generateRandomNum();
        }


        //compare values of the params
        void checkGuess(int num1, int num2)
        {
            if (num1 > num2)
            {
                MessageBox.Show("Your guess is too high");
                guessCounter++;
            }
            else if (num1 < num2)
            {
                MessageBox.Show("Your guess is too low");
                guessCounter++;
            }
            else if (num1 == num2)
            {
                MessageBox.Show("You guessed right, Congrats!");
                guessCounter = 0;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //assigning counter value to label
            incorrectGuessCount.Text = guessCounter.ToString();

            //grabbing string value of user input and converting to int
            string playerGuess = userInput.Text;
            int playerNum = int.Parse(playerGuess);


            checkGuess(playerNum, generatedNum);

        }


    }
}
