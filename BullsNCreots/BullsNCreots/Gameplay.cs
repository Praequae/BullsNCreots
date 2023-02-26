using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsNCreots
{
    public partial class GameplayFrm : Form
    {
        public GameplayFrm()
        {
            InitializeComponent();
        }
        
        string numbers = "0123456789";
        List<string> playerGuesses = new List<string>();
        List<string> computerGuesses = new List<string>();
        List<char> Valid = new List<char>();
        List<string> playerResults = new List<string>();
        List<string> computerResults = new List<string>();
        List<Tuple<string, int, int>> computerAnalysis = new List<Tuple<string, int, int>>();
        List<string> possibilities = new List<string>();
        string computerNumbers = "0123456789";
        string negatives = "";
        string savedNumbers = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private string ComputerGuess()
        {
            
            string guess = "";
            if(guesses == 0)
            {
                string compNumber = ComputerNumber(numbers);
                while (!CompNumValid(compNumber))
                {
                    compNumber = ComputerNumber(numbers);
                }
                computerGuesses.Add(compNumber);
                guess = compNumber;
            }
            else if(guesses == 1)
            {
                string firstGuess = computerGuesses[0];
                string numbers2 = ""; 
                foreach (char num in firstGuess)
                {
                    int index = computerNumbers.IndexOf(num);  
                    for(int i = 0; i < 11; i++)
                    {
                        if (!firstGuess.Contains(Convert.ToString(i)))
                        {
                            numbers2 += Convert.ToString(i);
                        }
                    }   
                }
                Random rand = new Random();
                string compNumber = "";
                for (int i = 0; i < 4; i++)
                {
                    int index = rand.Next(0, numbers2.Length - 1);
                    compNumber += numbers2[index];
                }
                guess = compNumber;
                
            }
            else if(savedNumbers.Length == 4)
            {
                    Random rand = new Random();
                    for(int a = 0; a < 4; a++)
                    {
                        int index = rand.Next(0, savedNumbers.Length - 1);
                        guess += savedNumbers[index];
                    }
                    if (!CompNumValid(guess) || computerGuesses.Contains(guess))
                    {
                        ComputerGuess();
                    }
            }
            else if (possibilities.Count > 0 && negatives.Length == 0)
            {
                Random rand = new Random();
                for (int i = 0; i < possibilities.Count; i++)
                {
                    int randomIndex = rand.Next(0, possibilities.Count - 1);
                    int randomNum = rand.Next(0, 3);
                    guess += possibilities[randomIndex][randomNum];
                }
                while(guess.Length < 4)
                {
                    int randomNum = rand.Next(0, computerNumbers.Length - 1);
                    guess += computerNumbers[randomNum];
                }
                if (!CompNumValid(guess))
                {
                    ComputerGuess();
                }
            }
            else if (guesses > 0 && negatives.Length == 0)
            {
                for(int j = 0; j < computerGuesses.Count; j++)
                {
                    if (computerAnalysis[j].Item2 > 0 || computerAnalysis[j].Item3 > 0)
                    {
                        
                        if (computerAnalysis[j].Item2 + computerAnalysis[j].Item3 == 4)
                        {
                            savedNumbers += computerAnalysis[j].Item1;
                            ComputerGuess();
                        }
                        else if (!possibilities.Contains(computerAnalysis[j].Item1))
                        {
                            possibilities.Add(computerAnalysis[j].Item1);
                            ComputerGuess();
                        }
                    }
                    else
                    {
                        foreach(char number in computerAnalysis[j].Item1)
                        {
                            negatives += number;
                            int index = computerNumbers.IndexOf(number);
                            computerNumbers.Remove(index);
                            ComputerGuess();
                        }
                    }
                   
                }
            }
            else if(negatives.Length > 0)
            {
                Random random = new Random();
                int randIndex = random.Next(0, computerNumbers.Length - 1);
                guess += negatives.Substring(0, 2) + computerNumbers[randIndex];
                if (!CompNumValid(guess))
                {
                    ComputerGuess();
                }

            }
            
            else
            {
                string compNumber = ComputerNumber(numbers);

                while (!CompNumValid(compNumber))
                {
                    compNumber = ComputerNumber(computerNumbers);
                }
                if (computerGuesses.Contains(guess))
                {
                    ComputerGuess();
                }
                else
                {
                    computerGuesses.Add(compNumber);
                    guess += compNumber;
                }
                
            }
            
            return guess;
            
        }
        private bool GuessTwice(string guess)
        {
            if (computerGuesses.Contains(guess))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Tuple<string, int, int> ComputerGuessResult(string guess, string playerNumber)
        {
            int bulls = 0;
            int creots = 0;
            foreach (char number in guess)
            {
                if (playerNumber.Contains(number))
                {
                    int index = playerNumber.IndexOf(number);
                    int guessIndex = guess.IndexOf(number);
                    if (index == guessIndex)
                    {
                        bulls++;
                    }
                    else
                    {
                        creots++;
                    }
                }
            }
            Tuple<string, int, int> computerResults = new Tuple<string, int, int>(guess, bulls, creots);
            
            computerAnalysis.Add(computerResults);
            return computerResults;
        }
        private Tuple<int, int> GuessResult(string guess, string computerNumber)
        {
            
            int bulls = 0;
            int creots = 0;
            foreach(char number in guess)
            {
                if (computerNumber.Contains(number))
                {
                    int index = computerNumber.IndexOf(number);
                    int guessIndex = guess.IndexOf(number);
                    if(index == guessIndex)
                    {
                        bulls++;
                    }
                    else
                    {
                        creots++;
                    }
                }
            }
            Tuple<int, int> results = new Tuple<int, int>(bulls, creots);
            
            return results;
        }
        private bool CompNumValid(string computerNumber)
        {
            bool repeat = NoRepeats(computerNumber);
            string valid = ValidEntry(computerNumber);
            if (!repeat && valid == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string ComputerNumber(string numberList)
        {
            int x = 0;
            string computerNumber = "";
            Random random = new Random();
            while(x < 4)
            {
                int index = random.Next(0, 10);
                computerNumber += numberList[index];
                x++;
            }
            return computerNumber;
            
            
        }
        private bool NoRepeats(string text)
        {
            bool repeats;
            int y = 0;
            Valid.Clear();
            foreach (char number in text)
            {
                if (!Valid.Contains(number))
                {
                    Valid.Add(number);
                }
                else
                {
                    y += 1;
                }
            }
            if (y > 0)
            {
                repeats = true;
            }
            else
            {
                repeats = false;
            }
            return repeats;
        }
        private string ValidEntry(string text)
        {
            string result = "";

            if (text.Length < 4 || text.Length > 4)
            {
                result += "Please enter 4 numbers.\r\n";
                foreach (char number in text)
                {
                    if (numbers.IndexOf(number) == -1)
                    {
                        bool repeat = NoRepeats(text);
                        if (repeat)
                        {
                            result += "Numbers may not repeat.\r\n";
                        }
                    }
                }
            }
            else
            {
                bool repeat = NoRepeats(text);
                if (repeat)
                {
                    result += "Numbers may not repeat.\r\n";
                }
                foreach (char number in text)
                {
                    if (numbers.IndexOf(number) == -1)
                    {
                        result += "Please enter 4 numbers.";
                        break;
                        
                    }
                    
                }

                

            }
            return result;
        }
        string computerNumber;
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string result = ValidEntry(InputTextbx.Text);

            string compNumber = ComputerNumber(numbers);
           
            if (result == "")
            {
                playerNumberLbl.Text = InputTextbx.Text;
                InputLbl.Hide();
                InputTextbx.Hide();
                PlayerGuessesLbl.Show();
                PlayerGuessesOutputLbl.Show();
                YourNumLbl.Show();
                playerNumberLbl.Show();
                CompNumLbl.Show();
                CompNumOutLbl.Show();
                CompGuessesOutputLbl.Show();
                ComputerGuessTitleLbl.Show();
                MakeAGuessLbl.Show();
                GuessTxtbx.Show();
                firstOutputLbl.Hide();
                OutputLbl.Show();
                SubmitBtn.Hide();
                GuessSubmitBtn.Show();
                NumGuessOutputLbl.Show();
                GuessNumLbl.Show();
                SubmitBtn.Enabled = false;
            }
            else
            {
                firstOutputLbl.Text = result;
            }
            while (!CompNumValid(compNumber))
            {
                compNumber = ComputerNumber(numbers);

            }
            CompNumOutLbl.Text = "????";
            computerNumber = compNumber;

        }
        int guesses = 0; 
        private async void GuessSubmitBtn_Click(object sender, EventArgs e)
        {
            string playerGuess = GuessTxtbx.Text;
            bool repeats = NoRepeats(playerGuess);
            string valid = ValidEntry(playerGuess);
            string playerNumber = playerNumberLbl.Text;
            if(!repeats && valid == "")
            {
                if (playerGuesses.Contains(playerGuess))
                {
                    OutputLbl.Text = "You have already made this guess.";
                }
                else
                {
                    PlayerGuessesOutputLbl.Text = "";
                    playerGuesses.Add(playerGuess);
                    Tuple<int, int> result = GuessResult(playerGuess, computerNumber);
                    if(result.Item1 == 1 && result.Item1 == 1)
                    {
                        playerResults.Add(playerGuess + " " + Convert.ToString(result.Item1) + " bull " + Convert.ToString(result.Item2) + " creot");
                    }
                    else if(result.Item1 == 1 && result.Item1 != 1)
                    {
                        playerResults.Add(playerGuess + " " + Convert.ToString(result.Item1) + " bull " + Convert.ToString(result.Item2) + " creots");
                    }
                    else if(result.Item1 != 1 && result.Item2 == 1)
                    {
                        playerResults.Add(playerGuess + " " + Convert.ToString(result.Item1) + " bulls " + Convert.ToString(result.Item2) + " creot");
                    }
                    else if(result.Item1 != 1 && result.Item2 != 1)
                    {
                        playerResults.Add(playerGuess + " " + Convert.ToString(result.Item1) + " bulls " + Convert.ToString(result.Item2) + " creots");
                    }
                    for(int i = 0; i < playerResults.Count; i++)
                    {
                        PlayerGuessesOutputLbl.Text += playerResults[i] + "\r\n";
                    }
                    OutputLbl.Text = playerResults[playerResults.Count - 1];
                    if (result.Item1 == 4)
                    {
                        guesses++;
                        NumGuessOutputLbl.Text = Convert.ToString(guesses);
                        OutputLbl.Text = "You win!";
                        CompNumOutLbl.Text = computerNumber;
                        await Task.Delay(2000);
                        OutputLbl.Text = "You guessed the computer's number in " + guesses + " guesses";
                        await Task.Delay(3000);
                        OutputLbl.Text = "Play Again?";
                        OutputLbl.Location = new Point(300, 239);
                        MakeAGuessLbl.Hide();
                        GuessTxtbx.Hide();
                        GuessSubmitBtn.Hide();
                        PlayAgainBtn.Show();
                    }
                    else
                    {
                        GuessTxtbx.Clear();
                        GuessTxtbx.Focus();
                        await Task.Delay(2000);
                        OutputLbl.Text = "Computer making guess";
                        await Task.Delay(500);
                        OutputLbl.Text += ".";
                        await Task.Delay(500);
                        OutputLbl.Text += ".";
                        await Task.Delay(500);
                        OutputLbl.Text += ".";
                        string computerGuess = ComputerGuess();
                        while (computerGuess == "" || !CompNumValid(computerGuess))
                        {
                            computerGuess = ComputerGuess();
                        }
                        OutputLbl.Text = "Computer's Guess is: " + computerGuess;
                        await Task.Delay(2000);
                        Tuple<string, int, int> results = ComputerGuessResult(computerGuess, playerNumber);
                        if(results.Item2 == 4)
                        {
                            guesses++;
                            NumGuessOutputLbl.Text = Convert.ToString(guesses);
                            OutputLbl.Text = "You Lose";
                            for (int x = 0; x < computerGuesses.Count; x++)
                            {
                                if (results.Item2 == 1 && results.Item3 == 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bull and " + results.Item3 + " creot\r\n";
                                }
                                else if (results.Item2 == 1 && results.Item3 != 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bull and " + results.Item3 + " creots\r\n";
                                }
                                else if (results.Item2 != 1 && results.Item3 == 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bulls and " + results.Item3 + " creot\r\n";
                                }
                                else
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bulls and " + results.Item3 + " creots\r\n";
                                }
                                await Task.Delay(2000);
                                OutputLbl.Text = "The computer has guessed your number in " + guesses + " guesses.";
                                await Task.Delay(3000);
                                OutputLbl.Text = "Play again?";
                                OutputLbl.Location = new Point(300, 239);
                                MakeAGuessLbl.Hide();
                                GuessTxtbx.Hide();
                                GuessSubmitBtn.Hide();
                                PlayAgainBtn.Show();

                            }
                        }
                        else
                        {
                            OutputLbl.Text = "Your turn.";

                            for (int x = 0; x < computerGuesses.Count; x++)
                            {
                                if (results.Item2 == 1 && results.Item3 == 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bull and " + results.Item3 + " creot\r\n";
                                }
                                else if (results.Item2 == 1 && results.Item3 != 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bull and " + results.Item3 + " creots\r\n";
                                }
                                else if (results.Item2 != 1 && results.Item3 == 1)
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bulls and " + results.Item3 + " creot\r\n";
                                }
                                else
                                {
                                    CompGuessesOutputLbl.Text += results.Item1 + " " + results.Item2 + " bulls and " + results.Item3 + " creots\r\n";
                                }
                            }
                            guesses++;
                            NumGuessOutputLbl.Text = Convert.ToString(guesses);
                        }
                        
                    }
                    
                }
            }
            else
            {
                OutputLbl.Text = valid;
            }
            

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            InstructionsFrm info = new InstructionsFrm();
            info.Show();
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            playerGuesses.Clear();
            computerGuesses.Clear();
            Valid.Clear();
            playerResults.Clear();
            computerResults.Clear();
            computerAnalysis.Clear();
            possibilities.Clear();
            negatives = "";
            savedNumbers = "";
            computerNumbers = "0123456789";
            InputLbl.Show();
            InputTextbx.Show();
            PlayerGuessesLbl.Hide();
            PlayerGuessesOutputLbl.Hide();
            YourNumLbl.Hide();
            playerNumberLbl.Hide();
            CompNumLbl.Hide();
            CompNumOutLbl.Hide();
            CompGuessesOutputLbl.Hide();
            ComputerGuessTitleLbl.Hide();
            MakeAGuessLbl.Hide();
            GuessTxtbx.Hide();
            firstOutputLbl.Show();
            OutputLbl.Hide();
            SubmitBtn.Show();
            GuessSubmitBtn.Hide();
            NumGuessOutputLbl.Hide();
            GuessNumLbl.Hide();
            SubmitBtn.Enabled = true;
            CompGuessesOutputLbl.Text = "";
            PlayerGuessesOutputLbl.Text = "";
            NumGuessOutputLbl.Text = "";
            playerNumberLbl.Text = "";
            CompNumOutLbl.Text = "????";
            guesses = 0;
            OutputLbl.Location = new Point(312, 461);
            InputTextbx.Text = "";
            InputTextbx.Focus();
            PlayAgainBtn.Hide();
            GuessTxtbx.Clear();


        }
    }
}
   
