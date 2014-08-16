using LockheedMartin.Prepar3D.SimConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimConnectTest
{
    public partial class Form1 : Form
    {
        const int WM_USER_SIMCONNECT = 0x0402;

        SimConnect simConnect = null;

        enum DEFINITIONS
        {
            MyStruct
        };

        enum DATA_REQUESTS
        {
            REQUEST_1
        };

        enum EVENTS
        {
            // COM1
            COM_RADIO_SET,
            COM_STBY_RADIO_SET,
            // flip flop
            COM_STBY_RADIO_SWAP,

            // COM2
            COM2_RADIO_SET,
            COM2_STBY_RADIO_SET,
            // flip flop
            COM2_RADIO_SWAP 
        };

        enum GROUP
        {
            ID_PRIORITY_STANDARD = 1900000000,
        };

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi, Pack=1)]
        struct MyStruct
        {
            //[MarshalAs(UnmanagedType.ByValTStr, SizeConst=256)]
            //public string com1;

            public int com1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (simConnect == null)
            {
                try
                {
                    simConnect = new SimConnect("MattTest", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    Init();

                }
                catch (COMException ex)
                {
                    DisplayTextNewLine(ex.Message);
                }
            }
        }

        private void Init()
        {
            try
            {
                // bind events
                simConnect.OnRecvOpen += simConnect_OnRecvOpen;
                simConnect.OnRecvQuit += simConnect_OnRecvQuit;
                simConnect.OnRecvException += simConnect_OnRecvException;

                // bind data structure
                simConnect.AddToDataDefinition(DEFINITIONS.MyStruct, "COM ACTIVE FREQUENCY:1", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                // register binding
                simConnect.RegisterDataDefineStruct<MyStruct>(DEFINITIONS.MyStruct);

                // map client events
                MapClientEvents();

                // bind event handling
                simConnect.OnRecvSimobjectDataBytype += simConnect_OnRecvSimobjectDataBytype;
            }
            catch (COMException ex)
            {
                DisplayText(ex.Message);
            }
        }

        void simConnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    {
                        MyStruct s1 = (MyStruct)data.dwData[0];
                        DisplayTextNewLine(s1.com1.ToString());
                        DisplayTextNewLine("Com1:" + BCD16ToFrequency(s1.com1));
                        break;
                    }

                default:
                    {
                        DisplayTextNewLine("Unknown request ID: " + data.dwRequestID);
                        break;
                    }
            }
        }

        void simConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            DisplayTextNewLine("Exception recieved: " + data.dwException);
        }

        void simConnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            DisplayTextNewLine("Prepar3D has exited");
            CloseConnection();
        }

        private void simConnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            DisplayTextNewLine("Connected to Prepar3D");
        }

        private void DisplayText(string text)
        {
            txtOutput.Text += text;
        }

        private void DisplayTextNewLine(string text)
        {
            DisplayText(text + Environment.NewLine);
        }

        private void CloseConnection()
        {
            if (simConnect != null)
            {
                simConnect.Dispose();
                simConnect = null;

                DisplayTextNewLine("Connection Closed");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simConnect != null)
                {
                    simConnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.MyStruct, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            DisplayTextNewLine("Request sent...");
        }

        private string BCD16ToFrequency(int bcd)
        {
            byte[] bytes = BitConverter.GetBytes(bcd);
            int high, low;
            int mhz, khz;

            // byte 1
            high = bytes[1] >> 4;
            low = bytes[1] & 0xF;
            mhz = (10 * high) + low;

            // byte 2
            high = bytes[0] >> 4;
            low = bytes[0] & 0xF;
            khz = (100 * high) + (low * 10);

            // calculate .25 spacing
            khz += (khz % 50 == 0 ? 0 : 5);

            return string.Format("1{0}.{1}", mhz, khz);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            uint freq = 10279;

            try
            {
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_STBY_RADIO_SET, freq, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM1_Click(object sender, EventArgs e)
        {
            try
            {
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_STBY_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM2_Click(object sender, EventArgs e)
        {
            try
            {   
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }              
        }

        private void MapClientEvents()
        {
            simConnect.MapClientEventToSimEvent(EVENTS.COM_STBY_RADIO_SET, "COM_STBY_RADIO_SET");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_STBY_RADIO_SWAP, "COM_STBY_RADIO_SWAP");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_SWAP, "COM2_RADIO_SWAP");
        }
    }
}
