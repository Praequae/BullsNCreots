namespace BullsNCreots
{
    partial class GameplayFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLbl = new System.Windows.Forms.Label();
            this.InputTextbx = new System.Windows.Forms.TextBox();
            this.InputLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerGuessesOutputLbl = new System.Windows.Forms.Label();
            this.playerNumberLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CompNumOutLbl = new System.Windows.Forms.Label();
            this.CompNumLbl = new System.Windows.Forms.Label();
            this.YourNumLbl = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.PlayerGuessesLbl = new System.Windows.Forms.Label();
            this.ComputerGuessTitleLbl = new System.Windows.Forms.Label();
            this.CompGuessesOutputLbl = new System.Windows.Forms.Label();
            this.GuessTxtbx = new System.Windows.Forms.TextBox();
            this.MakeAGuessLbl = new System.Windows.Forms.Label();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.firstOutputLbl = new System.Windows.Forms.Label();
            this.GuessSubmitBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.NumGuessOutputLbl = new System.Windows.Forms.Label();
            this.GuessNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(312, 58);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(254, 51);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Bulls && Creots";
            // 
            // InputTextbx
            // 
            this.InputTextbx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputTextbx.Location = new System.Drawing.Point(378, 185);
            this.InputTextbx.Name = "InputTextbx";
            this.InputTextbx.Size = new System.Drawing.Size(125, 28);
            this.InputTextbx.TabIndex = 2;
            // 
            // InputLbl
            // 
            this.InputLbl.AutoSize = true;
            this.InputLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputLbl.Location = new System.Drawing.Point(12, 188);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(360, 20);
            this.InputLbl.TabIndex = 4;
            this.InputLbl.Text = "Please enter a number for the computer to guess: ";
            this.InputLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(321, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Can you beat the computer?";
            // 
            // PlayerGuessesOutputLbl
            // 
            this.PlayerGuessesOutputLbl.BackColor = System.Drawing.SystemColors.Info;
            this.PlayerGuessesOutputLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerGuessesOutputLbl.Location = new System.Drawing.Point(12, 267);
            this.PlayerGuessesOutputLbl.Name = "PlayerGuessesOutputLbl";
            this.PlayerGuessesOutputLbl.Size = new System.Drawing.Size(251, 284);
            this.PlayerGuessesOutputLbl.TabIndex = 6;
            this.PlayerGuessesOutputLbl.Visible = false;
            // 
            // playerNumberLbl
            // 
            this.playerNumberLbl.BackColor = System.Drawing.SystemColors.Info;
            this.playerNumberLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNumberLbl.Location = new System.Drawing.Point(31, 73);
            this.playerNumberLbl.Name = "playerNumberLbl";
            this.playerNumberLbl.Size = new System.Drawing.Size(72, 33);
            this.playerNumberLbl.TabIndex = 7;
            this.playerNumberLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(220, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Guess the computer\'s number before it guesses yours!";
            // 
            // CompNumOutLbl
            // 
            this.CompNumOutLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompNumOutLbl.BackColor = System.Drawing.SystemColors.Info;
            this.CompNumOutLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompNumOutLbl.Location = new System.Drawing.Point(768, 73);
            this.CompNumOutLbl.Name = "CompNumOutLbl";
            this.CompNumOutLbl.Size = new System.Drawing.Size(72, 33);
            this.CompNumOutLbl.TabIndex = 9;
            this.CompNumOutLbl.Text = "????";
            this.CompNumOutLbl.Visible = false;
            // 
            // CompNumLbl
            // 
            this.CompNumLbl.AutoSize = true;
            this.CompNumLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompNumLbl.Location = new System.Drawing.Point(711, 40);
            this.CompNumLbl.Name = "CompNumLbl";
            this.CompNumLbl.Size = new System.Drawing.Size(168, 20);
            this.CompNumLbl.TabIndex = 10;
            this.CompNumLbl.Text = "Computer\'s Number";
            this.CompNumLbl.Visible = false;
            // 
            // YourNumLbl
            // 
            this.YourNumLbl.AutoSize = true;
            this.YourNumLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourNumLbl.Location = new System.Drawing.Point(12, 40);
            this.YourNumLbl.Name = "YourNumLbl";
            this.YourNumLbl.Size = new System.Drawing.Size(114, 20);
            this.YourNumLbl.TabIndex = 11;
            this.YourNumLbl.Text = "Your Number";
            this.YourNumLbl.Visible = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.Location = new System.Drawing.Point(388, 235);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(94, 29);
            this.SubmitBtn.TabIndex = 12;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // PlayerGuessesLbl
            // 
            this.PlayerGuessesLbl.AutoSize = true;
            this.PlayerGuessesLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerGuessesLbl.Location = new System.Drawing.Point(79, 235);
            this.PlayerGuessesLbl.Name = "PlayerGuessesLbl";
            this.PlayerGuessesLbl.Size = new System.Drawing.Size(112, 20);
            this.PlayerGuessesLbl.TabIndex = 13;
            this.PlayerGuessesLbl.Text = "Your Guesses";
            this.PlayerGuessesLbl.Visible = false;
            // 
            // ComputerGuessTitleLbl
            // 
            this.ComputerGuessTitleLbl.AutoSize = true;
            this.ComputerGuessTitleLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerGuessTitleLbl.Location = new System.Drawing.Point(690, 235);
            this.ComputerGuessTitleLbl.Name = "ComputerGuessTitleLbl";
            this.ComputerGuessTitleLbl.Size = new System.Drawing.Size(154, 20);
            this.ComputerGuessTitleLbl.TabIndex = 15;
            this.ComputerGuessTitleLbl.Text = "Computer Guesses";
            this.ComputerGuessTitleLbl.Visible = false;
            // 
            // CompGuessesOutputLbl
            // 
            this.CompGuessesOutputLbl.BackColor = System.Drawing.SystemColors.Info;
            this.CompGuessesOutputLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompGuessesOutputLbl.Location = new System.Drawing.Point(631, 267);
            this.CompGuessesOutputLbl.Name = "CompGuessesOutputLbl";
            this.CompGuessesOutputLbl.Size = new System.Drawing.Size(251, 284);
            this.CompGuessesOutputLbl.TabIndex = 14;
            this.CompGuessesOutputLbl.Visible = false;
            this.CompGuessesOutputLbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // GuessTxtbx
            // 
            this.GuessTxtbx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuessTxtbx.Location = new System.Drawing.Point(378, 301);
            this.GuessTxtbx.Name = "GuessTxtbx";
            this.GuessTxtbx.Size = new System.Drawing.Size(125, 28);
            this.GuessTxtbx.TabIndex = 16;
            this.GuessTxtbx.Visible = false;
            // 
            // MakeAGuessLbl
            // 
            this.MakeAGuessLbl.AutoSize = true;
            this.MakeAGuessLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MakeAGuessLbl.Location = new System.Drawing.Point(351, 267);
            this.MakeAGuessLbl.Name = "MakeAGuessLbl";
            this.MakeAGuessLbl.Size = new System.Drawing.Size(200, 20);
            this.MakeAGuessLbl.TabIndex = 17;
            this.MakeAGuessLbl.Text = "Make a 4 Number Guess";
            this.MakeAGuessLbl.Visible = false;
            // 
            // OutputLbl
            // 
            this.OutputLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OutputLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputLbl.Location = new System.Drawing.Point(312, 449);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(281, 90);
            this.OutputLbl.TabIndex = 18;
            this.OutputLbl.Text = "Make a Guess";
            this.OutputLbl.Visible = false;
            // 
            // firstOutputLbl
            // 
            this.firstOutputLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstOutputLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstOutputLbl.Location = new System.Drawing.Point(336, 281);
            this.firstOutputLbl.Name = "firstOutputLbl";
            this.firstOutputLbl.Size = new System.Drawing.Size(230, 67);
            this.firstOutputLbl.TabIndex = 19;
            // 
            // GuessSubmitBtn
            // 
            this.GuessSubmitBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuessSubmitBtn.Location = new System.Drawing.Point(388, 355);
            this.GuessSubmitBtn.Name = "GuessSubmitBtn";
            this.GuessSubmitBtn.Size = new System.Drawing.Size(94, 29);
            this.GuessSubmitBtn.TabIndex = 20;
            this.GuessSubmitBtn.Text = "Submit";
            this.GuessSubmitBtn.UseVisualStyleBackColor = true;
            this.GuessSubmitBtn.Visible = false;
            this.GuessSubmitBtn.Click += new System.EventHandler(this.GuessSubmitBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(487, 406);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showBtn.Location = new System.Drawing.Point(289, 406);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(170, 29);
            this.showBtn.TabIndex = 22;
            this.showBtn.Text = "Show Instructions";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // NumGuessOutputLbl
            // 
            this.NumGuessOutputLbl.BackColor = System.Drawing.SystemColors.Info;
            this.NumGuessOutputLbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumGuessOutputLbl.Location = new System.Drawing.Point(40, 147);
            this.NumGuessOutputLbl.Name = "NumGuessOutputLbl";
            this.NumGuessOutputLbl.Size = new System.Drawing.Size(60, 48);
            this.NumGuessOutputLbl.TabIndex = 23;
            this.NumGuessOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumGuessOutputLbl.Visible = false;
            // 
            // GuessNumLbl
            // 
            this.GuessNumLbl.AutoSize = true;
            this.GuessNumLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuessNumLbl.Location = new System.Drawing.Point(1, 120);
            this.GuessNumLbl.Name = "GuessNumLbl";
            this.GuessNumLbl.Size = new System.Drawing.Size(159, 20);
            this.GuessNumLbl.TabIndex = 24;
            this.GuessNumLbl.Text = "Number of Guesses";
            this.GuessNumLbl.Visible = false;
            // 
            // GameplayFrm
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 560);
            this.Controls.Add(this.GuessNumLbl);
            this.Controls.Add(this.NumGuessOutputLbl);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.GuessSubmitBtn);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.MakeAGuessLbl);
            this.Controls.Add(this.GuessTxtbx);
            this.Controls.Add(this.ComputerGuessTitleLbl);
            this.Controls.Add(this.CompGuessesOutputLbl);
            this.Controls.Add(this.PlayerGuessesLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.YourNumLbl);
            this.Controls.Add(this.CompNumLbl);
            this.Controls.Add(this.CompNumOutLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerNumberLbl);
            this.Controls.Add(this.PlayerGuessesOutputLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputLbl);
            this.Controls.Add(this.InputTextbx);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.firstOutputLbl);
            this.Name = "GameplayFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulls & Creots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private TextBox InputTextbx;
        private Label InputLbl;
        private Label label2;
        private Label PlayerGuessesOutputLbl;
        private Label playerNumberLbl;
        private Label label5;
        private Label CompNumOutLbl;
        private Label CompNumLbl;
        private Label YourNumLbl;
        private Button SubmitBtn;
        private Label PlayerGuessesLbl;
        private Label ComputerGuessTitleLbl;
        private Label CompGuessesOutputLbl;
        private TextBox GuessTxtbx;
        private Label MakeAGuessLbl;
        private Label OutputLbl;
        private Label firstOutputLbl;
        private Button GuessSubmitBtn;
        private Button ExitBtn;
        private Button showBtn;
        private Label NumGuessOutputLbl;
        private Label GuessNumLbl;
    }
}