using System;
using System.Collections.Generic;
using System.IO.Ports; //needs to be referenced by entire package
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace LoadCell_OwnProgram
{
    public class ThermoClass
    {
        private string name = "Thermocouple Array";
        private string comPort = "COM7";
        private int buadRate = 115200; //DO NOT CHANGE uncless arduino sketch is changed as well
        //private SerialPort serialPort = new SerialPort(comPort, buadRate); // update comPort var with the serial port of your Arduino board
        private SerialPort serialPort;

        private List<float> tc1Data = new List<float>(); //TC1 data structure
        private List<float> tc2Data = new List<float>(); //TC2 data structure
        private List<float> tc3Data = new List<float>(); //TC3 data structure
        private List<float> tc4Data = new List<float>(); //TC4 data structure

        //Constructor
        public ThermoClass()
        {

            serialPort = new SerialPort("COM5", 115200);
            Console.WriteLine("Default constructor");
            Console.WriteLine("Serial port status: " + serialPort.IsOpen);
            serialPort.Open();
        }
        public ThermoClass(string comPort)//opening com port
        {
            serialPort = new SerialPort(comPort, 115200);
            Console.WriteLine("Parametrized constructor");
            Console.WriteLine("Serial port status: " + serialPort.IsOpen);
            serialPort.Open();
        }

        //Get and set functions for name
        public void setName(string userInputName) { name = userInputName; }
        public string getName() { return name; }

        //Get and set functions for com port
        public void setComPort(string userInputComPort) { comPort = userInputComPort; }
        public string getComPort() { return comPort; }

        //Get and set functions for baud rate
        public void setBaudRate(int userInputBaudRate) { buadRate = userInputBaudRate; }
        public int getBuadRate() { return buadRate; }

        //Returns all temperature readings of TC 1 [should be the PID TC] & adds single temp reading to TC1 data array 
        public List<float> getTC1Data() { return tc1Data; }
        public float getCurrentTC1Temp() { return tc1Data[tc1Data.Count - 1]; }
        public void addTemp1(float temp) { tc1Data.Add(temp); }

        //TC2
        public List<float> getTC2Data() { return tc2Data; }
        public float getCurrentTC2Temp() { return tc2Data[tc2Data.Count - 1]; }
        public void addTemp2(float temp) { tc2Data.Add(temp); }

        //TC 3
        public List<float> getTC3Data() { return tc3Data; }
        public float getCurrentTC3Temp() { return tc3Data[tc3Data.Count - 1]; }
        public void addTemp3(float temp) { tc3Data.Add(temp); }

        //TC 4
        public List<float> getTC4Data() { return tc4Data; }
        public float getCurrentTC4Temp() { return tc4Data[tc4Data.Count - 1]; }
        public void addTemp4(float temp) { tc4Data.Add(temp); }

        //Record all 4 temperature readings
        public List<float> recordCurrentTemps()
        {
            //Data array with float variables read in from arduino, getCurrentTemps used to read in from serial port (arduino) and to convert string to float list w/ the 4 temps
            List<float> currentTempList = this.getCurrentTemps();

            //Add data to TC data structures
            addTemp1(currentTempList[0]);
            addTemp2(currentTempList[1]);
            addTemp3(currentTempList[2]);
            addTemp4(currentTempList[3]);

            return currentTempList;
        }

        //Returns all 4 temperature readings as List
        public List<float> getCurrentTemps()
        {

            if (this.serialPort.BytesToRead > 0)
            {

                string data = serialPort.ReadLine().Trim();
                List<float> currentTemps = new List<float>();

                foreach (string str in data.Split(','))
                {
                    float temp;
                    if (float.TryParse(str, out temp))
                    {
                        currentTemps.Add(temp);
                    }
                }

                if (currentTemps.Count == 4)
                {
                    return currentTemps;
                }

                else
                {
                    return null; // Handle the case where the input string doesn't contain exactly 4 numbers... - need to change to exception throwing
                }

            }

            else
            {
                return null; //No data collected from serial port - need to change to exception throwing
            }
        }
    
    }
}
*/