using System;
using System.Windows.Forms;
using System.Threading;
using FUTEK_USB_DLL;
using Zaber.Motion;
using Zaber.Motion.Ascii;
using SpinnakerNET;
using SpinnakerNET.GenApi;
using Spinnaker;
using System.IO;
using System.Collections.Generic;
using Zaber.Motion.Binary;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
//CARSONNNNSSS
namespace LoadCell_OwnProgram
{
    public partial class MainForm : Form
    {
        // Create a new instance of the TestingClass within MainForm
        TestingClass testingClass = new TestingClass();

        //Initialize Button. Moves grip to home position and runs "Initialize" thread from testing.cs
        private void InitializeButton_Click(object sender, EventArgs e)
        {
            //Disable initialization button
            InitializeButton.Enabled = false;
            //Enable start button
            StartButton.Enabled = true;
            //Calls on Initialize from TestingClass
            TestingClass initProcess = new TestingClass();
            initProcess.Initialize();
        }


        //Start Button. Runs RunningTest and StoringData from TestingClass.cs
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Disable the start button
            StartButton.Enabled = false;
            // Create two separate tasks to run StoringData and RunningTest
            Task storingDataTask = Task.Run(() => testingClass.StoringData());
            Task runningTestTask = Task.Run(() => testingClass.RunningTest());
            Task updateGuiTask = Task.Run(() => updateGui());
        }

        //Stop Button.
        private void StopButton_Click(object sender, EventArgs e)
        {

            // Runs StoppingTest()
            Task stoppingDataTask = Task.Run(() => testingClass.StoppingTest());

            //closes GUI
            this.Close();
            Application.Exit();
        }

        //Function that updates GUI while test is running
        public void updateGui()
        {
            var timer = new System.Threading.Timer(  //Timer rather than a loop bc a loop screws with load cell
                callback: (_) => //Method that runs when the timer ticks
                {
                    // update the ForceLabel, StressLabel, TimeLabel, and DispOutput on the main thread
                    this.Invoke((MethodInvoker)delegate {
                        ForceLabel.Text = TestingClass.force.ToString();
                    });
                    this.Invoke((MethodInvoker)delegate {
                        StressLabel.Text = TestingClass.stress.ToString();
                    });
                    this.Invoke((MethodInvoker)delegate {
                        TimeLabel.Text = TestingClass.timeElapsed.ToString();
                    });
                    this.Invoke((MethodInvoker)delegate {
                        DispLabel.Text = TestingClass.displacement.ToString();
                    });
                },
                state: null,//timer stuff
                dueTime: 0,//amount of time delay before the timer initially starts
                period: 100);//interval between timer ticks
            var stopped = new ManualResetEvent(false); // Wait for the timer to stop before returning. This will keep the StoringData method running until the timer is stopped
            stopped.WaitOne(); //wait for event to be signaled
            timer.Dispose(); // Dispose the timer to free up resources
        }
        //Updating the GUI 
        private void ForceLabel_Click(object sender, EventArgs e)
        {
            ForceLabel.Text = TestingClass.force.ToString();
        }
        private void StressLabel_Click(object sender, EventArgs e)
        {
            StressLabel.Text = TestingClass.stress.ToString();
        }
        private void TimeLabel_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = TestingClass.timeElapsed.ToString();
        }
        private void DispLabel_Click(object sender, EventArgs e)
        {
            DispLabel.Text = TestingClass.displacement.ToString();
        }

        //Default geometries, strainrate, and acquisiton rate. These values only change if 
        public static decimal length = 5;
        public static decimal width = 1;
        public static decimal thick = 1;
        public static decimal strainrate = .001m; // default is 10^-3 [1/s]
        public static decimal acq_rate = 0.2m; //default acquisiton rate set to 0.2 Hz

        //Functions that change the value of the variables only if the user inputs new values in the GUI
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)//taking user input to determine gauge length
        {
            length = (decimal)numericUpDown1.Value;
        }
        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            width = (decimal)numericUpDown2.Value;
        }
        public void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            thick = (decimal)numericUpDown3.Value;
        }
        public void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            strainrate = (decimal)numericUpDown4.Value;
        }
        public void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            acq_rate = (decimal)numericUpDown5.Value; //if user input is entered then this changes acq rate variable
        }

        //trying to make the .csv file able to be renamed / relocated
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "CSV file (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // Save the file with the chosen file name and location
            }

        }

        //Opening the window and loading the MainForm
        public MainForm() //This is needed to open up the window
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
