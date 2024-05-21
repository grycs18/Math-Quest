using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Media;
using System.IO;
using System.Resources;


namespace HangMath
{
    public partial class Lobby : Form
    {
        private Random random = new Random();
        private int correctAnswer;
        private Button[] answerButtons;
        private int num1, num2;
        private char[] operators;
        private char selectedOperator;
        private int currentRound = 1;
        private int score = 0;
        private Timer timer;
        private int timeLeft = 30;
        private SoundPlayer sounds;
        private bool gameStarted = false; 
        private bool isFlowLayoutVisible = false;
        private int incorrectAttempts = 0;

       private bool gameEnded = false;
        private PictureBox restartpictureBox;
        private PictureBox exitpictureBox;

      
       
       
       
        public Lobby()
        {
            InitializeComponent();
            playtextBox1.ReadOnly = true; // Set playtextBox1 as not editable
            numtextBox1.ReadOnly = true;
            sounds = new SoundPlayer("Untold Journey - The Pirate King (Royalty Free Music) (320).wav");
            sounds.Play();          
            InitializeTimer();
            button3.Text = "Back";
           
        }
         private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Settimer1Tick;
        }
          

        private void RestartPictureBox_Click(object sender, EventArgs e)
        {
           // Reset game state
		    currentRound = 1;
		    score = 0;
		    incorrectAttempts = 0;
		    timeLeft = 30;
		    gameEnded = false; // Reset gameEnded flag
		    gameStarted = false; // Reset gameStarted flag
		
		    // Reset UI elements
		    foreach (Control control in Controls)
		    {
		        control.Visible = true; // Show all controls
		    }
		
		    // Reset heart picture boxes
		    heartpictureBox3.Visible = true;
		    heartpictureBox4.Visible = true;
		    heartpictureBox5.Visible = true;
		
		    // Reset score label
		    UpdateScoreLabel();
		
		    // Reset round label
		    UpdateRoundLabel();
		
		    // Reset numtextBox1 text
		    numtextBox1.Text = "";
		
		    // Reset time label
		    timelabel1.Text = "Time left: 30 seconds";
		    
		    notiflabel1.Text = "";
		
		    // Start a new game
		    StartGame();
		
		    // Hide restart and exit buttons
		    restartpictureBox.Hide();
		    exitpictureBox.Hide();
		    
		    // Hide flow layout panel
    		setflowLayoutPanel1.Hide();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
           MainForm mainForm = new MainForm();
		        mainForm.Show();
		        this.Close();
        }
       
        private void InitializeGame()
        {
        	 

            // Show the PictureBox when it is clicked
            pictureBox1.Click += PictureBox1Click;

            // Hide all controls except pictureBox1 and linkLabel2
            HideAllControls();
            
            // Initialize restartPictureBox
            restartpictureBox = new PictureBox();
            restartpictureBox.Click += RestartPictureBox_Click;

            // Initialize exitpictureBox
            exitpictureBox = new PictureBox();
            exitpictureBox.Click += ExitPictureBox_Click;
            
            
            // Hide all controls except pictureBox1 and linkLabel2
            HideAllControls();
        }
        void PictureBox1Click(object sender, EventArgs e)
		{
			 gameStarted = true;
            pictureBox1.Visible = true;
            // Show all controls except flowLayoutPanel1
    		ShowAllControlsExceptFlowLayoutPanel();
            StartGame();
		}
         private void HideAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control != pictureBox1 && control != linkLabel2)
                {
                    control.Visible = false;
                }
            }
        }

       private void ShowAllControlsExceptFlowLayoutPanel()
		{
		    foreach (Control control in Controls)
		    {
		        if (control != setflowLayoutPanel1)
		        {
		            control.Visible = true;
		        }
		    }
		}
        private void SetOperators()
        {
            if (currentRound >= 1 && currentRound <= 10)
            {
                operators = new char[] { '+', '-' };
            }
            else if (currentRound >= 11 && currentRound <= 20)
            {
                operators = new char[] { '+', '-', '*' };
            }
            else if (currentRound >= 21 && currentRound <= 30)
            {
                operators = new char[] { '+', '-', '*', '/' };
            }
        }

        private void StartGame()
        {
        	gameStarted = true;
        	button3.Text = "Resume";
        	pictureBox1.Visible = false;
			
        	
        	SetOperators();
            GenerateQuestion();
            GenerateAndAddButtonsWithAnswers();

            timeLeft = 30;
            timelabel1.Text = "Time left: 30 seconds";
            timer.Start();
            
             // Update the round label
    		UpdateRoundLabel();
        }

        private void GenerateQuestion()
        {
            num1 = random.Next(1, 51);

		    // Ensure that an operator is present
		    if (operators != null && operators.Length > 0)
		    {
		        selectedOperator = operators[random.Next(0, operators.Length)];
		        num2 = random.Next(1, 51); // Generate num2 after selecting the operator
		
		        numtextBox1.Text = num1 + " " + selectedOperator + " " + num2 + " = ?";
		        CalculateCorrectAnswer();
		    }
		    else
		    {
		        // If no operator is present, generate a default question with addition operator
		        selectedOperator = '+';
		        num2 = random.Next(1, 51);
		        numtextBox1.Text = num1 + " " + selectedOperator + " " + num2 + " = ?";
		        CalculateCorrectAnswer();
		    }
        }

        private void CalculateCorrectAnswer()
        {
            switch (selectedOperator)
            {
                case '+':
                    correctAnswer = num1 + num2;
                    break;
                case '-':
                    correctAnswer = num1 - num2;
                    break;
                case '*':
                    correctAnswer = num1 * num2;
                    break;
                case '/':
                    correctAnswer = num1 / num2;
                    break;
            }
        }

        private void GenerateAndAddButtonsWithAnswers()
        {
        	 if (!gameStarted || gameEnded) return;
             panel1.Controls.Clear();

		    List<int> answers = new List<int> { correctAnswer };
		    while (answers.Count < 3)
		    {
		        int possibleAnswer = correctAnswer + random.Next(-10, 11);
		        if (!answers.Contains(possibleAnswer) && possibleAnswer != correctAnswer)
		        {
		            answers.Add(possibleAnswer);
		        }
		    }
		      
		
		    int buttonWidth = 75; // Width of each button
		    int buttonHeight = 23; // Height of each button
		    int minDistance = 76; // Minimum distance between buttons
		
		    answerButtons = new Button[3];
		    for (int i = 0; i < 3; i++)
		    {
		        int x, y;
		        bool overlapping;
		        do
		        {
		            overlapping = false;
		            x = random.Next(panel1.Width - buttonWidth); // Random X position within the panel width
		            y = random.Next(panel1.Height - buttonHeight); // Random Y position within the panel height
		
		            // Check if the new button overlaps with any existing buttons
		            foreach (Button button in answerButtons)
		            {
		                if (button != null && Math.Abs(button.Location.X - x) < minDistance && Math.Abs(button.Location.Y - y) < minDistance)
		                {
		                    overlapping = true;
		                    break;
		                }
		            }
		        } while (overlapping); // Repeat until a non-overlapping position is found
		
		        answerButtons[i] = new Button
		        {
		            Size = new Size(buttonWidth, buttonHeight),
		            Location = new Point(x, y),
		            Font = new Font("MS UI Gothic", 12, FontStyle.Regular),
		            BackColor = Color.DarkGoldenrod,
		            ForeColor = Color.White,
		            Text = answers[i].ToString(),
		            Tag = answers[i] == correctAnswer,
		            Visible = true
		        };
		        answerButtons[i].Click += AnswerButton_Click;
		        panel1.Controls.Add(answerButtons[i]);
		    }	   
		}
      
    

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            bool isCorrect = (bool)clickedButton.Tag;

            if (isCorrect)
            {
                notiflabel1.Text = "Correct!";
                score += CalculatePoints();
           
            }
            else
            {
                notiflabel1.Text = "Incorrect!";
                incorrectAttempts++;
                RemoveHearts();
            }
			
            UpdateScoreLabel();
            currentRound++;
            
                 
        	
            if (currentRound > 30)
            {
                EndGame();
            }
            else
            {
                SetOperators();
                StartGame();
            }
        }

        private int CalculatePoints()
        {
            if (currentRound >= 1 && currentRound <= 10)
            {
                return 5;
            }
            else if (currentRound >= 11 && currentRound <= 20)
            {
                return 10;
            }
            else if (currentRound >= 21 && currentRound <= 30)
            {
                return 20;
            }
            return 0;
        }

		  private void EndGame()
        {
            timer.Stop();
			gameEnded = true;
		    // Hide all controls except panel1
		     
		    foreach (Control control in Controls)
		    {
		        if (control != panel1)
		        {
		            control.Visible = false;
		        }
		    }
		
		     // Load images from files
		    string basePath = Path.Combine(Application.StartupPath, "Resources");
		
		    PictureBox gameOverPictureBox = new PictureBox
		    {
		        Image = Image.FromFile(Path.Combine(basePath, "GameOver.gif")),
		        SizeMode = PictureBoxSizeMode.AutoSize,
		        Location = new Point(panel1.Width / 2 - 130, -5)
		        
		    };
		
		    PictureBox restartPictureBox = new PictureBox
		    {
		        Image = Image.FromFile(Path.Combine(basePath, "Restart.gif")),
		        SizeMode = PictureBoxSizeMode.AutoSize,
		        Location = new Point(panel1.Width / 2 - 90, 60), // Adjusted for better alignment
		       	Visible = true,
		       	Cursor = Cursors.Hand
		    };
		    restartPictureBox.Click += RestartPictureBox_Click;
				
		      PictureBox exitPictureBox = new PictureBox
		    {
		        Image = Image.FromFile(Path.Combine(basePath, "Exit.gif")),
		        SizeMode = PictureBoxSizeMode.AutoSize,
		        Location = new Point(panel1.Width / 2 - 90, 110), // Adjusted for better alignment
		       Visible = true,
		       	Cursor = Cursors.Hand
		    };
		    exitPictureBox.Click += ExitPictureBox_Click;
		
		    panel1.Controls.Clear(); // Clear existing controls in panel1
		    panel1.Controls.Add(gameOverPictureBox);
		    panel1.Controls.Add(restartPictureBox);
		    panel1.Controls.Add(exitPictureBox);
           
        }
		  
		 
        private void UpdateScoreLabel()
        {
            playtextBox1.Text = "Score: " + score;
        }
		
		
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Toggle the visibility of the flowLayoutPanel1
		    isFlowLayoutVisible = !isFlowLayoutVisible;
		    setflowLayoutPanel1.Visible = isFlowLayoutVisible;
		
		    // Pause the game when settings are opened
		    if (isFlowLayoutVisible)
		    {
		        PauseGame();
		         // Set LinkLabel properties when the flow layout panel is closed
		        linkLabel2.LinkColor = Color.SaddleBrown;
		        linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
		        setflowLayoutPanel1.BringToFront(); // Ensure the flowLayoutPanel1 is in front
		    }
		    else
		    {
		        ResumeGame();
		         // Set LinkLabel properties when the flow layout panel is closed
		        linkLabel2.LinkColor = Color.White;
		        linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
		    }
		}
		
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				checkBox1.Text = "Unmute";
				sounds.Stop();
			}
			else
			{
				checkBox1.Text = "Mute";
				sounds.Play();
			}
		}
		
		 private void Settimer1Tick(object sender, EventArgs e)
        {
            if (operators != null && operators.Length > 0)
		    {
		        selectedOperator = operators[random.Next(0, operators.Length)];
		        if (timeLeft > 0)
		        {
		            timeLeft--;
		            timelabel1.Text = "Time left: " + timeLeft + " seconds";
		        }
		        else
		        {
		            timer.Stop();
		            notiflabel1.Text = "Time's up!";
		            incorrectAttempts++;
                	RemoveHearts();
		            currentRound++;
		            if (currentRound > 30)
		            {
		                EndGame();
		            }
		            else
		            {
		                SetOperators();
		                StartGame();
		            }
		        }
		    }
        }
		  private void RemoveHearts()
        {
            if (incorrectAttempts == 1)
            {
                heartpictureBox5.Visible = false;
            }
            else if (incorrectAttempts == 2)
            {
                heartpictureBox4.Visible = false;
            }
            else if (incorrectAttempts == 3)
            {
                heartpictureBox3.Visible = false;
                EndGame(); // End the game if all hearts are gone
            }
        }
		
		
		 private void UpdateRoundLabel()
		{
		    label4.Text = "Round: " + currentRound;
		}
		 private void PauseGame()
        {
		 	if (gameStarted)
		 	{
            	timer.Stop();
		 	}
        }

        private void ResumeGame()
        {
        	if (gameStarted)
		 	{
            	timer.Start();
        	}
        }
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			 if (checkBox2.Checked)
    		{
			 	this.Cursor = Cursors.WaitCursor; 
			 	MainForm vincent = new MainForm();
			 	vincent.ShowDialog();
			 	this.Hide();
			}
			 else
			 {
			 	this.Cursor = Cursors.Hand;
			 }
			
		}
		
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			 if (!gameStarted)
		    {
		        // If the game is not started, the button text should be "Back"
		        isFlowLayoutVisible = !isFlowLayoutVisible;
		        setflowLayoutPanel1.Visible = isFlowLayoutVisible;
		        button3.Text = "Back"; // Update button text
		
		        if (!isFlowLayoutVisible)
		        {
		            // If flow layout panel is not visible, pause the game
		            PauseGame();
		             // Set LinkLabel properties when the flow layout panel is closed
			        linkLabel2.LinkColor = Color.White;
			        linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
		        }
		        else
		        {
		            // If flow layout panel is visible, resume the game
		            ResumeGame();
		            // Set LinkLabel properties when the flow layout panel is opened
			        linkLabel2.LinkColor = Color.SaddleBrown;
			        linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
		        }
		
			        
		    }
		    else
		    {
		        // If the game is started, the button text should be "Resume"
		        isFlowLayoutVisible = !isFlowLayoutVisible;
		        setflowLayoutPanel1.Visible = isFlowLayoutVisible;
		        button3.Text = "Resume"; // Update button text
		
		        if (isFlowLayoutVisible)
		        {
		            // If flow layout panel is visible, pause the game and timer
		            PauseGame();
		        }
		        else
		        {
		            // If flow layout panel is not visible, resume the game and timer
		            ResumeGame();
		            // Set LinkLabel properties when the flow layout panel is opened
			        linkLabel2.LinkColor = Color.SaddleBrown;
			        linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
		        }
		
		        // Show the link label when the settings panel is closed and set its color to white
		        linkLabel2.Visible = true;
		        linkLabel2.LinkColor = Color.White;
		        linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
		    }
		}
		void LobbyLoad(object sender, EventArgs e)
		{
			 // Initialize the game when the form loads
            InitializeGame();
            button3.Text = "Back";
		}
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		void PlaytextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void PlaytextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Notiflabel1Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			
		}
		void Timelabel1Click(object sender, EventArgs e)
		{
			
		}
		
		void ExcheckBox2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void Playerlabel1Click(object sender, EventArgs e)
		{
			
		}
		
		void NumtextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void AnstextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void SetflowLayoutPanel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		
		
		void GamepictureBox3Click(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			
		}
		
		void HeartpictureBox4Click(object sender, EventArgs e)
		{
			
		}
		
		void HeartpictureBox5Click(object sender, EventArgs e)
		{
			
		}
	}
}
