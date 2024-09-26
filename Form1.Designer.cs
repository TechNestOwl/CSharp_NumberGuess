namespace NumberGuessingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLbl = new Label();
            title2Lbl = new Label();
            playButton = new Button();
            playerGuessLbl = new Label();
            incorrectGuessCount = new Label();
            userInput = new TextBox();
            incorrectGuessLabel = new Label();
            correctGuessLabel = new Label();
            correctGuessCount = new Label();
            genNumButton = new Button();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Historic", 16.2782612F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(343, 53);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(223, 36);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Guess A Number";
            // 
            // title2Lbl
            // 
            title2Lbl.AutoSize = true;
            title2Lbl.Location = new Point(416, 101);
            title2Lbl.Name = "title2Lbl";
            title2Lbl.Size = new Size(55, 20);
            title2Lbl.TabIndex = 1;
            title2Lbl.Text = "1 - 100";
            // 
            // playButton
            // 
            playButton.Location = new Point(550, 246);
            playButton.Name = "playButton";
            playButton.Size = new Size(90, 28);
            playButton.TabIndex = 2;
            playButton.Text = "Play Game";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // playerGuessLbl
            // 
            playerGuessLbl.AutoSize = true;
            playerGuessLbl.Font = new Font("Segoe UI", 8.765218F, FontStyle.Underline, GraphicsUnit.Point, 0);
            playerGuessLbl.Location = new Point(132, 170);
            playerGuessLbl.Name = "playerGuessLbl";
            playerGuessLbl.Size = new Size(112, 20);
            playerGuessLbl.TabIndex = 3;
            playerGuessLbl.Text = "Guess Attempts";
            // 
            // incorrectGuessCount
            // 
            incorrectGuessCount.AutoSize = true;
            incorrectGuessCount.Cursor = Cursors.No;
            incorrectGuessCount.Location = new Point(109, 254);
            incorrectGuessCount.Name = "incorrectGuessCount";
            incorrectGuessCount.Size = new Size(17, 20);
            incorrectGuessCount.TabIndex = 4;
            incorrectGuessCount.Text = "0";
            // 
            // userInput
            // 
            userInput.Location = new Point(377, 246);
            userInput.Name = "userInput";
            userInput.PlaceholderText = "1 -100";
            userInput.Size = new Size(94, 26);
            userInput.TabIndex = 5;
            // 
            // incorrectGuessLabel
            // 
            incorrectGuessLabel.AutoSize = true;
            incorrectGuessLabel.Location = new Point(72, 211);
            incorrectGuessLabel.Name = "incorrectGuessLabel";
            incorrectGuessLabel.Size = new Size(109, 20);
            incorrectGuessLabel.TabIndex = 6;
            incorrectGuessLabel.Text = "Incorrect Guess";
            // 
            // correctGuessLabel
            // 
            correctGuessLabel.AutoSize = true;
            correctGuessLabel.Location = new Point(205, 211);
            correctGuessLabel.Name = "correctGuessLabel";
            correctGuessLabel.Size = new Size(99, 20);
            correctGuessLabel.TabIndex = 7;
            correctGuessLabel.Text = "Correct Guess";
            // 
            // correctGuessCount
            // 
            correctGuessCount.AutoSize = true;
            correctGuessCount.Location = new Point(240, 254);
            correctGuessCount.Name = "correctGuessCount";
            correctGuessCount.Size = new Size(17, 20);
            correctGuessCount.TabIndex = 8;
            correctGuessCount.Text = "0";
            // 
            // genNumButton
            // 
            genNumButton.Location = new Point(550, 193);
            genNumButton.Name = "genNumButton";
            genNumButton.Size = new Size(90, 28);
            genNumButton.TabIndex = 9;
            genNumButton.Text = "Generate Number";
            genNumButton.UseVisualStyleBackColor = true;
            genNumButton.Click += genNumButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 762);
            Controls.Add(genNumButton);
            Controls.Add(correctGuessCount);
            Controls.Add(correctGuessLabel);
            Controls.Add(incorrectGuessLabel);
            Controls.Add(userInput);
            Controls.Add(incorrectGuessCount);
            Controls.Add(playerGuessLbl);
            Controls.Add(playButton);
            Controls.Add(title2Lbl);
            Controls.Add(titleLbl);
            Name = "Form1";
            Text = "C# Number Guessing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label title2Lbl;
        private Button playButton;
        private Label playerGuessLbl;
        private Label incorrectGuessCount;
        private TextBox userInput;
        private Label incorrectGuessLabel;
        private Label correctGuessLabel;
        private Label correctGuessCount;
        private Button genNumButton;
    }
}
