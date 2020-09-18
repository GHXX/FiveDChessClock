using FiveDChessDataInterface;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FiveDChessClock
{
    public partial class MainForm : Form
    {
        private DataInterface chessInterface;
        private long gameTimeMs = 1000 * 60 * 20;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            ResetTimes();

            while (!DataInterface.TryCreateAutomatically(out this.chessInterface, out int numProcesses))
            {
                if (numProcesses == 0)
                    Console.WriteLine("Please start the game...");
                else
                    Console.WriteLine($"Please exit all additional game instances! ({numProcesses} detected)");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Process found. Initializing...");
            this.chessInterface.Initialize();
            Console.WriteLine("Ready! Monitoring memory...");
            this.TmrUpdate.Enabled = true;
        }

        private void BtnSetTime_Click(object sender, EventArgs e)
        {
            var form2 = new EnterTimeForm(this.gameTimeMs);
            var res = form2.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.gameTimeMs = form2.CurrentTime;
                ResetTimes();
            }
        }

        private int lastPlayer = -1;
        private bool gameRunning = false;
        private long timeRemainingWhiteMs = -1;
        private long timeRemainingBlackMs = -1;

        private void TmrUpdate_Tick(object sender, EventArgs e)
        {
            if (this.chessInterface.GetChessBoardAmount() > 0)
            {
                if (!this.gameRunning)
                {
                    ResetTimes();
                    this.gameRunning = true;
                    Console.WriteLine("Game has started.");
                    this.TmrDisplayUpdate.Enabled = true;
                    this.timeSinceLastTick.Restart();
                    this.BtnSetTime.Enabled = false;
                }

                var cp = this.chessInterface.GetCurrentPlayersTurn();
                if (cp >= 0 && this.lastPlayer != cp) // if its any players turn, and the player changed
                {
                    Console.WriteLine($"It's now {(cp == 0 ? "WHITE" : "BLACK")}'s turn!");
                    this.lastPlayer = cp;
                }
            }
            else if (this.gameRunning)
            {
                Console.WriteLine("Game has ended!");
                this.gameRunning = false;
                ResetTimes();
            }
        }

        private void ResetTimes()
        {
            this.TmrDisplayUpdate.Enabled = false;
            this.BtnSetTime.Enabled = true;
            this.timeSinceLastTick.Reset();

            this.timeRemainingBlackMs = this.timeRemainingWhiteMs = this.gameTimeMs;
            DisplayTimes();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        readonly Stopwatch timeSinceLastTick = new Stopwatch();

        private void TmrDisplayUpdate_Tick(object sender, EventArgs e)
        {

            var timeElapsed = this.timeSinceLastTick.ElapsedMilliseconds;
            this.timeSinceLastTick.Restart();

            if (this.lastPlayer == 0)
            {
                this.timeRemainingWhiteMs -= timeElapsed;
            }
            else if (this.lastPlayer == 1)
            {
                this.timeRemainingBlackMs -= timeElapsed;
            }

            if (this.timeRemainingWhiteMs <= 0 || this.timeRemainingBlackMs <= 0)
            {
                this.TmrDisplayUpdate.Enabled = false;
                this.timeSinceLastTick.Reset();
            }

            DisplayTimes();
        }

        private void DisplayTimes()
        {
            this.LblTimeRemainingWhite.Text = TimeHelper.FormatTime(this.timeRemainingWhiteMs);
            this.LblTimeRemainingWhite.ForeColor = this.timeRemainingWhiteMs > 0 ? Color.Black : Color.Red;

            this.LblTimeRemainingBlack.Text = TimeHelper.FormatTime(this.timeRemainingBlackMs);
            this.LblTimeRemainingBlack.ForeColor = this.timeRemainingBlackMs > 0 ? Color.Black : Color.Red;
        }
    }
}
