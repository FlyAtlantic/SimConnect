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
            Radios
        };

        enum DATA_REQUESTS
        {
            REQUEST_RADIOS
        };

        enum EVENTS
        {
            // COM1
            COM_RADIO_SET,
            COM_STBY_RADIO_SET,
            // flip flop
            COM_STBY_RADIO_SWAP,
            // knobs
            COM_RADIO_WHOLE_DEC, // Mhz down
            COM_RADIO_WHOLE_INC, // Mhz up
            COM_RADIO_FRACT_DEC, // KHz down
            COM_RADIO_FRACT_INC, // KHz up

            // COM2
            COM2_RADIO_SET,
            COM2_STBY_RADIO_SET,
            // flip flop
            COM2_RADIO_SWAP,
            // knobs
            COM2_RADIO_WHOLE_DEC, // Mhz down
            COM2_RADIO_WHOLE_INC, // Mhz up
            COM2_RADIO_FRACT_DEC, // KHz down
            COM2_RADIO_FRACT_INC, // KHz up

            // NAV1
            NAV1_RADIO_SET,
            NAV1_STBY_SET,
            // flip flop
            NAV1_RADIO_SWAP,
            // knobs
            NAV1_RADIO_WHOLE_DEC, // Mhz down
            NAV1_RADIO_WHOLE_INC, // Mhz up
            NAV1_RADIO_FRACT_DEC, // KHz down
            NAV1_RADIO_FRACT_INC, // KHz up

            // NAV2
            NAV2_RADIO_SET,
            NAV2_STBY_SET,
            // flip flop
            NAV2_RADIO_SWAP,
            // knobs
            NAV2_RADIO_WHOLE_DEC, // Mhz down
            NAV2_RADIO_WHOLE_INC, // Mhz up
            NAV2_RADIO_FRACT_DEC, // KHz down
            NAV2_RADIO_FRACT_INC // KHz up
        };

        enum GROUP
        {
            ID_PRIORITY_STANDARD = 1900000000,
        };

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi, Pack=1)]
        struct Radios
        {
            //[MarshalAs(UnmanagedType.ByValTStr, SizeConst=256)]
            //public string com1;

            public int COM1ActiveFrequency;
            public int COM1StandbyFrequency;
            public int COM2ActiveFrequency;
            public int COM2StandbyFrequency;

            public int NAV1ActiveFrequency;
            public int NAV1StandbyFrequency;
            public int NAV2ActiveFrequency;
            public int NAV2StandbyFrequency;

            public int TransponderCode;
        }

        public Form1()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////
        // Radios
        ////////////////////////////////////////////////////////////////////////

        private void HandleRadios(SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            Radios s1 = (Radios)data.dwData[0];
            
            // com1
            txtCOM1Active.Text = BCD16ToFrequency(s1.COM1ActiveFrequency);
            txtCOM1Standby.Text = BCD16ToFrequency(s1.COM1StandbyFrequency);

            // com2
            txtCOM2Active.Text = BCD16ToFrequency(s1.COM2ActiveFrequency);
            txtCOM2Standby.Text = BCD16ToFrequency(s1.COM2StandbyFrequency);
        
            // nav1
            txtNAV1Active.Text = BCD16ToFrequency(s1.NAV1ActiveFrequency);
            txtNAV1Standby.Text = BCD16ToFrequency(s1.NAV1StandbyFrequency);

            // nav2
            txtNAV2Active.Text = BCD16ToFrequency(s1.NAV2ActiveFrequency);
            txtNAV2Standby.Text = BCD16ToFrequency(s1.NAV2StandbyFrequency);

            txtTransponder.Text = BCO16ToFrequency(s1.TransponderCode);
        }

        ////////////////////////////////////////////////////////////////////////
        // COM1
        ////////////////////////////////////////////////////////////////////////

        private void btnCOM1MHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_RADIO_WHOLE_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
                
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM1MHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_RADIO_WHOLE_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
                
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM1KHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_RADIO_FRACT_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
                
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM1KHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_RADIO_FRACT_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
                
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
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM_STBY_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
                
                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////
        // COM2
        ////////////////////////////////////////////////////////////////////////

        private void btnCOM2_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM2MHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_WHOLE_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM2MHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_WHOLE_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM2KHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_FRACT_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnCOM2KHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.COM2_RADIO_FRACT_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////
        // NAV1
        ////////////////////////////////////////////////////////////////////////

        private void btnNAV1MHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV1_RADIO_WHOLE_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV1MHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV1_RADIO_WHOLE_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV1KHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV1_RADIO_FRACT_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV1KHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV1_RADIO_FRACT_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV1_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV1_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////
        // NAV2
        ////////////////////////////////////////////////////////////////////////

        private void btnNAV2_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV2_RADIO_SWAP, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV2MHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV2_RADIO_WHOLE_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV2MHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV2_RADIO_WHOLE_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV2KHzUp_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV2_RADIO_FRACT_INC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        private void btnNAV2KHzDown_Click(object sender, EventArgs e)
        {
            try
            {
                // send event
                simConnect.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENTS.NAV2_RADIO_FRACT_DEC, 0, GROUP.ID_PRIORITY_STANDARD, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                // get status
                simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);

                DisplayTextNewLine("Request sent...");
            }
            catch (COMException ex)
            {
                DisplayTextNewLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////
        // Utilities
        ////////////////////////////////////////////////////////////////////////

        private string BCD16ToFrequency(int bcd)
        {
            byte[] bytes = BitConverter.GetBytes(bcd);
            int high, low;
            int mhz, khz;

            // byte 1
            high = bytes[1] >> 4;
            low = bytes[1] & 0xF;
            mhz = (10 * high) + low;

            // byte 0
            high = bytes[0] >> 4;
            low = bytes[0] & 0xF;
            khz = (100 * high) + (low * 10);

            // calculate .25 spacing
            khz += (khz % 50 == 0 ? 0 : 5);

            return string.Format("1{0}.{1}", mhz, khz);
        }

        private string BCO16ToFrequency(int bco)
        {
            byte[] bytes = BitConverter.GetBytes(bco);
            int high, low;
            string code;

            // byte 0
            high = bytes[1] >> 4;
            low = bytes[1] & 0xF;

            code = Convert.ToString(high, 8);
            code += Convert.ToString(low, 8);

            // byte 1
            high = bytes[0] >> 4;
            low = bytes[0] & 0xF;

            code += Convert.ToString(high, 8);
            code += Convert.ToString(low, 8);

            return code;
        }

        private void DisplayText(string text)
        {
            txtOutput.AppendText(text);
        }

        private void DisplayTextNewLine(string text)
        {
            DisplayText(text + Environment.NewLine);
        }

        ////////////////////////////////////////////////////////////////////////
        // SimConnect
        ////////////////////////////////////////////////////////////////////////

        private void Init()
        {
            try
            {
                // bind events
                simConnect.OnRecvOpen += simConnect_OnRecvOpen;
                simConnect.OnRecvQuit += simConnect_OnRecvQuit;
                simConnect.OnRecvException += simConnect_OnRecvException;

                // bind data structure
                // COM1
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "COM ACTIVE FREQUENCY:1", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "COM STANDBY FREQUENCY:1", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                // COM2
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "COM ACTIVE FREQUENCY:2", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "COM STANDBY FREQUENCY:2", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                // NAV1
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "NAV ACTIVE FREQUENCY:1", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "NAV STANDBY FREQUENCY:1", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                // NAV2
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "NAV ACTIVE FREQUENCY:2", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "NAV STANDBY FREQUENCY:2", "Frequency BCD16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                // TRANSPONDER
                simConnect.AddToDataDefinition(DEFINITIONS.Radios, "TRANSPONDER CODE:1", "BCO16", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                
                // register binding
                simConnect.RegisterDataDefineStruct<Radios>(DEFINITIONS.Radios);

                // map client events
                MapClientEvents();

                // bind event handling
                simConnect.OnRecvSimobjectDataBytype += simConnect_OnRecvSimobjectDataBytype;

                // request data
                GetInitialData();
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
                case DATA_REQUESTS.REQUEST_RADIOS:
                    {
                        HandleRadios(data);
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

        private void CloseConnection()
        {
            if (simConnect != null)
            {
                simConnect.Dispose();
                simConnect = null;

                DisplayTextNewLine("Connection Closed");
            }
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

        private void GetInitialData()
        {
            simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_RADIOS, DEFINITIONS.Radios, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            DisplayTextNewLine("Request sent...");
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            GetInitialData();
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

        private void MapClientEvents()
        {
            // COM1
            simConnect.MapClientEventToSimEvent(EVENTS.COM_STBY_RADIO_SET, "COM_STBY_RADIO_SET");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_STBY_RADIO_SWAP, "COM_STBY_RADIO_SWAP");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_RADIO_WHOLE_DEC, "COM_RADIO_WHOLE_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_RADIO_WHOLE_INC, "COM_RADIO_WHOLE_INC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_RADIO_FRACT_DEC, "COM_RADIO_FRACT_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM_RADIO_FRACT_INC, "COM_RADIO_FRACT_INC");

            // COM2
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_STBY_RADIO_SET, "COM2_STBY_RADIO_SET");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_SWAP, "COM2_RADIO_SWAP");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_WHOLE_DEC, "COM2_RADIO_WHOLE_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_WHOLE_INC, "COM2_RADIO_WHOLE_INC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_FRACT_DEC, "COM2_RADIO_FRACT_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.COM2_RADIO_FRACT_INC, "COM2_RADIO_FRACT_INC");

            // NAV1
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_STBY_SET, "NAV1_STBY_SET");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_RADIO_SWAP, "NAV1_RADIO_SWAP");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_RADIO_WHOLE_DEC, "NAV1_RADIO_WHOLE_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_RADIO_WHOLE_INC, "NAV1_RADIO_WHOLE_INC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_RADIO_FRACT_DEC, "NAV1_RADIO_FRACT_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV1_RADIO_FRACT_INC, "NAV1_RADIO_FRACT_INC");

            // NAV2
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_STBY_SET, "NAV2_STBY_SET");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_RADIO_SWAP, "NAV2_RADIO_SWAP");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_RADIO_WHOLE_DEC, "NAV2_RADIO_WHOLE_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_RADIO_WHOLE_INC, "NAV2_RADIO_WHOLE_INC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_RADIO_FRACT_DEC, "NAV2_RADIO_FRACT_DEC");
            simConnect.MapClientEventToSimEvent(EVENTS.NAV2_RADIO_FRACT_INC, "NAV2_RADIO_FRACT_INC");
        }

        ////////////////////////////////////////////////////////////////////////
        // TRANSPONDER
        ////////////////////////////////////////////////////////////////////////

        private void btnTransponderOff_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponderSby_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponderTst_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponderOn_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponderAlt_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponderIdent_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder0_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder1_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder2_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder3_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder4_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder5_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder6_Click(object sender, EventArgs e)
        {

        }

        private void btnTransponder7_Click(object sender, EventArgs e)
        {

        }
    }
}
