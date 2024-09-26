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
        int guessCounter = 0;


        //generate number 1 - 100
        int generateRandomNum()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        }


        //compare values of the params
        void checkGuess(int num1, int num2)
        {
            if (num1 > num2)
            {
                MessageBox.Show("Your guess is too high");
            }
            else if (num1 < num2)
            {
                MessageBox.Show("Your guess is too low");
            }
            else if (num1 == num2)
            {
                MessageBox.Show("You guessed right, Congrats!");
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {


        }
    }
}
