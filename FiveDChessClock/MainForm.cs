using FiveDChessDataInterface;
using System;
using System.Windows.Forms;

namespace FiveDChessClock
{
    public partial class MainForm : Form
    {
        private DataInterface chessInterface;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            while (!DataInterface.TryCreateAutomatically(out this.chessInterface, out int numProcesses))
            {
                if (numProcesses == 0)
                    Console.WriteLine("Please start the game...");
                else
                    Console.WriteLine($"Please exit all additional game instances! ({numProcesses} detected)");
            }
            chessInterface.Initialize();
            TmrUpdate.Enabled = true;
        }

        private void BtnSetTime_Click(object sender, EventArgs e)
        {

        }

        private void TmrUpdate_Tick(object sender, EventArgs e)
        {

        }
    }
}
