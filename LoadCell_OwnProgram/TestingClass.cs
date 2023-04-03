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
using System.Threading.Tasks; //multiple tasks can run simulataneously
using System.Runtime.CompilerServices;


namespace LoadCell_OwnProgram
{

    public class TestingClass
    {
        public List<double[]> dataList = new List<double[]>(); //creates a global list of doubles
        public Int32 UnitCode;
        public Int32 OffsetVal;
        public Int32 FullVal;
        public Int32 FullLoadVal;
        public Int32 DeciPoint;
        public Int32 NormalVal;
        public Double CalcVal;
        public Int32 act_count;
        public StreamWriter writer;
        

        //Creating an instance of ActuatorClass, LoadCellClass within TestingClass
        private ActuatorClass actuator = new ActuatorClass();
        private LoadCellClass loadCell = new LoadCellClass();
        private CameraClass camera = new CameraClass();
        //private ThermoClass thermocoupleData = new ThermoClass("COM9");


        //Called upon whenever the initialize button is pressed. Connects to actuator, tells it to move to home position, and prompts user to load sample. 
        public void Initialize()
        {
            using (var connection = Zaber.Motion.Ascii.Connection.OpenSerialPort("COM10")) //change this based on what computer you're using - port that your controller is connected to 
            {
                connection.EnableAlerts(); //connecting to actuator
                var deviceList = connection.DetectDevices();
                Console.WriteLine($"Found {deviceList.Length} devices.");
                var device = deviceList[0];
                var axis = device.GetAxis(1);
                if (!axis.IsHomed())
                {
                    axis.Home();
                }
                axis.MoveAbsolute(60, Units.Length_Millimetres);
                MessageBox.Show("Grips are now at home position. Load the sample and press Start button when you are ready to begin test.");
            
                //Verifying that a serial port connection exists and data is being communcated, should create better interface for this
                //Might be helpful to allow user to select COM port here for all devices
                /*if (thermocoupleData.getCurrentTemps().Count() > 0)
                {

                    Console.WriteLine("Connection successfully with thermocuple data acquisition tool.");

                }
                else
                {

                    //Error handlings - need to change this to try/catch blocks
                    throw("CONNECTION FAILED - Arduno UNO");
                }*/
            }
        }

        public DateTime FirstExportTime { get; private set; } //Making it a global variable so StoringData() can ref it
        public TimeSpan timeSinceFirstExport; //Making it a global variable so MainForm and StoringData() can reference it 
        //Called upon whenever the start button is pressed. 
        public void RunningTest()
        {
            FirstExportTime = DateTime.Now;//Timer starts when button is pressed
            Task loadCellTask = Task.Run(() => loadCell.LoadCell(MainForm.width, MainForm.thick, ref force, ref stress));
            Task actuatorTask = Task.Run(() => actuator.LinearActuator(ref displacement));
            Task cameraTask = Task.Run(() => camera.MainMethodRun());
        }


        public static int displacement; //defining private field to store value of displacement for ActuatorClass
        public static double force; //defining private field to store value of force for LoadCellClass
        public static double stress; //defining private field to store value of stress for LoadCellClass
        public static double timeElapsed;

        public void StoringData()
        {
            var timer = new System.Threading.Timer(  //timer rather than a loop bc a loop screws with load cell
                callback: (_) => //method that runs when the timer ticks
                {
                    timeSinceFirstExport = (DateTime.Now - FirstExportTime);//total time elapsed since first data point
                    timeElapsed = timeSinceFirstExport.TotalSeconds;

                    //List<float> temp = thermocoupleData.recordCurrentTemps();//tc stuff
                    var data = new double[] { timeElapsed, displacement, force, stress };//, temp[0], temp[1], temp[2], temp[3] }; //create an array of doubles
                    dataList.Add(data); //adding array to list of arrays (dataList)
                },
                state: null,//timer stuff
                dueTime: 0,//amount of time delay before the timer initially starts
                period: Convert.ToInt32(1000 / MainForm.acq_rate));//interval between timer ticks. this converts acq_rate from Hz to ms between ticks
            var stopped = new ManualResetEvent(false); // Wait for the timer to stop before returning. This will keep the StoringData method running until the timer is stopped
            stopped.WaitOne(); //wait for event to be signaled
            timer.Dispose(); // Dispose the timer to free up resources
        }

        //Called upon whenever the stop button is pressed. Exports array to .csv.
        public void StoppingTest()
        {
            string path = "test_data.csv"; //file location for where to save the data
            string delimiter = ","; //delimiter used to separate values in the CSV file
            using (StreamWriter sw = new StreamWriter(path))
            {
                // Write headers to the file
                sw.WriteLine("[s] Time Elapsed" + delimiter + "[um] Displacement" + delimiter + "[N] Force" + delimiter + "[MPa] Stress" + delimiter );

                // Write data to the file
                foreach (double[] data in dataList)
                {
                    string line = string.Join(delimiter, data);
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("The test has been stopped");
        }
    }
}
